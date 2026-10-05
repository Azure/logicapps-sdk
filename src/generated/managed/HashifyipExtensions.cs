//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hashifyip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HashifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildMD4GET))]
        public IBodyWorkflowAction<MD4GETResponse> MD4GET([WorkflowExpression] Func<string> value)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MD4GETResponse> __BuildMD4GET(WorkflowValue<string> value)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            return new DeferredBodyAction<MD4GETResponse>(() =>
            {
                var apiCallPath = "/hash/md4/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                return new ApiConnectionAction<MD4GETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildMD4POST))]
        public IBodyWorkflowAction<MD4POSTResponse> MD4POST([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MD4POSTResponse> __BuildMD4POST(WorkflowValue<string> value, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<MD4POSTResponse>(() =>
            {
                var apiCallPath = "/hash/md4/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<MD4POSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildMD4POSTFile))]
        public IBodyWorkflowAction<MD4POSTFileResponse> MD4POSTFile([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> file)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MD4POSTFileResponse> __BuildMD4POSTFile(WorkflowValue<string> value, WorkflowValue<string> file)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<MD4POSTFileResponse>(() =>
            {
                var apiCallPath = "/hash/md4/base64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                return new ApiConnectionAction<MD4POSTFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildMD5GET))]
        public IBodyWorkflowAction<MD5GETResponse> MD5GET([WorkflowExpression] Func<string> value)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MD5GETResponse> __BuildMD5GET(WorkflowValue<string> value)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            return new DeferredBodyAction<MD5GETResponse>(() =>
            {
                var apiCallPath = "/hash/md5/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                return new ApiConnectionAction<MD5GETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildMD5POST))]
        public IBodyWorkflowAction<MD5POSTResponse> MD5POST([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MD5POSTResponse> __BuildMD5POST(WorkflowValue<string> value, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<MD5POSTResponse>(() =>
            {
                var apiCallPath = "/hash/md5/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<MD5POSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildMD5POSTFile))]
        public IBodyWorkflowAction<MD5POSTFileResponse> MD5POSTFile([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> file)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MD5POSTFileResponse> __BuildMD5POSTFile(WorkflowValue<string> value, WorkflowValue<string> file)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<MD5POSTFileResponse>(() =>
            {
                var apiCallPath = "/hash/md5/base64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                return new ApiConnectionAction<MD5POSTFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildHighway256POST))]
        public IBodyWorkflowAction<Highway256POSTResponse> Highway256POST([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> xHashifyKey, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Highway256POSTResponse> __BuildHighway256POST(WorkflowValue<string> key, WorkflowValue<string> contentType, WorkflowValue<string> xHashifyKey, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(key, nameof(key), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(xHashifyKey, nameof(xHashifyKey), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<Highway256POSTResponse>(() =>
            {
                var apiCallPath = "/hash/highway/base64url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<Highway256POSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildHighway256RandomPOST))]
        public IBodyWorkflowAction<Highway256RandomPOSTResponse> Highway256RandomPOST([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> xHashifyKey, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Highway256RandomPOSTResponse> __BuildHighway256RandomPOST(WorkflowValue<string> key, WorkflowValue<string> contentType, WorkflowValue<string> xHashifyKey, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(key, nameof(key), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(xHashifyKey, nameof(xHashifyKey), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<Highway256RandomPOSTResponse>(() =>
            {
                var apiCallPath = "/hash/highway/base32";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<Highway256RandomPOSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildHighway64RandomPOST))]
        public IBodyWorkflowAction<Highway64RandomPOSTResponse> Highway64RandomPOST([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> xHashifyKey, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Highway64RandomPOSTResponse> __BuildHighway64RandomPOST(WorkflowValue<string> key, WorkflowValue<string> contentType, WorkflowValue<string> xHashifyKey, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(key, nameof(key), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(xHashifyKey, nameof(xHashifyKey), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<Highway64RandomPOSTResponse>(() =>
            {
                var apiCallPath = "/hash/highway-64/base32";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<Highway64RandomPOSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildHighway128GET))]
        public IBodyWorkflowAction<Highway128GETResponse> Highway128GET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> key)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Highway128GETResponse> __BuildHighway128GET(WorkflowValue<string> value, WorkflowValue<string> key)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway128GETResponse>(() =>
            {
                var apiCallPath = "/hash/highway-128/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
                return new ApiConnectionAction<Highway128GETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildHighway128RandomPOST))]
        public IBodyWorkflowAction<Highway128RandomPOSTResponse> Highway128RandomPOST([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> xHashifyKey, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Highway128RandomPOSTResponse> __BuildHighway128RandomPOST(WorkflowValue<string> key, WorkflowValue<string> contentType, WorkflowValue<string> xHashifyKey, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(key, nameof(key), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(xHashifyKey, nameof(xHashifyKey), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<Highway128RandomPOSTResponse>(() =>
            {
                var apiCallPath = "/hash/highway-128/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<Highway128RandomPOSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildHighway128RandomGET))]
        public IBodyWorkflowAction<Highway128RandomGETResponse> Highway128RandomGET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> key)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Highway128RandomGETResponse> __BuildHighway128RandomGET(WorkflowValue<string> value, WorkflowValue<string> key)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway128RandomGETResponse>(() =>
            {
                var apiCallPath = "/hash/highway128";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
                return new ApiConnectionAction<Highway128RandomGETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildHighway64RandomGET))]
        public IBodyWorkflowAction<Highway64RandomGETResponse> Highway64RandomGET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> key)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Highway64RandomGETResponse> __BuildHighway64RandomGET(WorkflowValue<string> value, WorkflowValue<string> key)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway64RandomGETResponse>(() =>
            {
                var apiCallPath = "/hash/highway64";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
                return new ApiConnectionAction<Highway64RandomGETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildHighway64POST))]
        public IBodyWorkflowAction<Highway64POSTResponse> Highway64POST([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> xHashifyKey, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Highway64POSTResponse> __BuildHighway64POST(WorkflowValue<string> key, WorkflowValue<string> contentType, WorkflowValue<string> xHashifyKey, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(key, nameof(key), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(xHashifyKey, nameof(xHashifyKey), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<Highway64POSTResponse>(() =>
            {
                var apiCallPath = "/hash/highway64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<Highway64POSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildHighway256RandomGET))]
        public IBodyWorkflowAction<Highway256RandomGETResponse> Highway256RandomGET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> key)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Highway256RandomGETResponse> __BuildHighway256RandomGET(WorkflowValue<string> value, WorkflowValue<string> key)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway256RandomGETResponse>(() =>
            {
                var apiCallPath = "/hash/highway";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
                return new ApiConnectionAction<Highway256RandomGETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildSHA1GET))]
        public IBodyWorkflowAction<SHA1GETResponse> SHA1GET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> digestFormat)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SHA1GETResponse> __BuildSHA1GET(WorkflowValue<string> value, WorkflowValue<string> digestFormat)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(digestFormat, nameof(digestFormat), required: true);
            return new DeferredBodyAction<SHA1GETResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/hash/sha1/{0}", ExpressionConverter.ConvertWithUrlEncoding(digestFormat, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                return new ApiConnectionAction<SHA1GETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildSHA1POSTForm))]
        public IBodyWorkflowAction<M200> SHA1POSTForm([WorkflowExpression] Func<string> xHashifyProcess, [WorkflowExpression] Func<string> digestFormat, [WorkflowExpression] Func<string> file)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<M200> __BuildSHA1POSTForm(WorkflowValue<string> xHashifyProcess, WorkflowValue<string> digestFormat, WorkflowValue<string> file)
        {
            WorkflowValue.Validate(xHashifyProcess, nameof(xHashifyProcess), required: true);
            WorkflowValue.Validate(digestFormat, nameof(digestFormat), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<M200>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/hash/sha1/{0}", ExpressionConverter.ConvertWithUrlEncoding(digestFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Hashify-Process"] = ExpressionConverter.Convert(xHashifyProcess);
                return new ApiConnectionAction<M200>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildSHA256GET))]
        public IBodyWorkflowAction<SHA256GETResponse> SHA256GET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> digestFormat)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SHA256GETResponse> __BuildSHA256GET(WorkflowValue<string> value, WorkflowValue<string> digestFormat)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(digestFormat, nameof(digestFormat), required: true);
            return new DeferredBodyAction<SHA256GETResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/hash/sha256/{0}", ExpressionConverter.ConvertWithUrlEncoding(digestFormat, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                return new ApiConnectionAction<SHA256GETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        [WorkflowExpressionFactory(nameof(__BuildSHA256BodyPOST))]
        public IBodyWorkflowAction<SHA256BodyPOSTResponse> SHA256BodyPOST([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> digestFormat, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SHA256BodyPOSTResponse> __BuildSHA256BodyPOST(WorkflowValue<string> value, WorkflowValue<string> digestFormat, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(digestFormat, nameof(digestFormat), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<SHA256BodyPOSTResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/hash/sha256/{0}", ExpressionConverter.ConvertWithUrlEncoding(digestFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<SHA256BodyPOSTResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildKeygen))]
        public IBodyWorkflowAction<M200> Keygen([WorkflowExpression] Func<string> keyLength)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<M200> __BuildKeygen(WorkflowValue<string> keyLength)
        {
            WorkflowValue.Validate(keyLength, nameof(keyLength), required: true);
            return new DeferredBodyAction<M200>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keygen/{0}", ExpressionConverter.ConvertWithUrlEncoding(keyLength, 1));
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
