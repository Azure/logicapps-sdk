//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webcontents
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebcontentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webcontents")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetFileContent(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetFileContent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webcontents")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InvokeHttp(Expression<Func<requestmethodInput>> requestmethod, Expression<Func<string>> requesturlOfTheRequest, Expression<Func<string>> requestbodyOfTheRequest = null)
        {
            var __workflow_requestmethod = WorkflowExpression.Compile(requestmethod, nameof(requestmethod), required: true);
            var __workflow_requesturlOfTheRequest = WorkflowExpression.Compile(requesturlOfTheRequest, nameof(requesturlOfTheRequest), required: true);
            var __workflow_requestbodyOfTheRequest = WorkflowExpression.Compile(requestbodyOfTheRequest, nameof(requestbodyOfTheRequest), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/InvokeHttp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["method"] = ExpressionConverter.ConvertO(__workflow_requestmethod);
                requestpropCount++;
                request["url"] = ExpressionConverter.ConvertO(__workflow_requesturlOfTheRequest);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    request["headers"] = headersObject;
                    requestpropCount++;
                }

                if (__workflow_requestbodyOfTheRequest != null)
                {
                    request["body"] = ExpressionConverter.ConvertO(__workflow_requestbodyOfTheRequest);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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