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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InvokeHttp(Expression<Func<InvokeHttpInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/InvokeHttp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class WebcontentsTriggers([ConnectionName] string connectionId)
    {
    }

    public class InvokeHttpInput
    {
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        public InvokeHttpInputMethodType Method { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UrlOfTheRequest { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("body")]
        public string BodyOfTheRequest { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvokeHttpInputMethodType
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