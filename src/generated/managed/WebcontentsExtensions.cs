//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webcontents
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebcontentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webcontents")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContent))]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> path)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileContent(WorkflowValue<string> path)
        {
            WorkflowValue.Validate(path, nameof(path), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/GetFileContent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webcontents")]
        [WorkflowExpressionFactory(nameof(__BuildInvokeHttp))]
        public IBodyWorkflowAction<JToken> InvokeHttp([WorkflowExpression] Func<requestmethodInput> requestmethod, [WorkflowExpression] Func<string> requesturlOfTheRequest, [WorkflowExpression] Func<string> requestbodyOfTheRequest = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildInvokeHttp(WorkflowValue<requestmethodInput> requestmethod, WorkflowValue<string> requesturlOfTheRequest, WorkflowValue<string> requestbodyOfTheRequest = null)
        {
            WorkflowValue.Validate(requestmethod, nameof(requestmethod), required: true);
            WorkflowValue.Validate(requesturlOfTheRequest, nameof(requesturlOfTheRequest), required: true);
            WorkflowValue.Validate(requestbodyOfTheRequest, nameof(requestbodyOfTheRequest), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/codeless/InvokeHttp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["method"] = ExpressionConverter.ConvertO(requestmethod);
                requestpropCount++;
                request["url"] = ExpressionConverter.ConvertO(requesturlOfTheRequest);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    request["headers"] = headersObject;
                    requestpropCount++;
                }

                if (requestbodyOfTheRequest != null)
                {
                    request["body"] = ExpressionConverter.ConvertO(requestbodyOfTheRequest);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class WebcontentsTriggers([ConnectionName] string connectionId)
    {
    }

    public enum requestmethodInput
    {
        GET,
        DELETE,
        PATCH,
        POST,
        PUT
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Webcontents;

    public partial class WorkflowManagedActions
    {
        public WebcontentsActions Webcontents(string connectionId) => new WebcontentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WebcontentsTriggers Webcontents(string connectionId) => new WebcontentsTriggers(connectionId);
    }
}
