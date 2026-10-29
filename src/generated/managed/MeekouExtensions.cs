//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Meekou
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MeekouActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response, ApiConnectionActionConfiguration> HtmlToPdf(Expression<Func<string>> htmlContent = null, Expression<Func<string>> xCustomHost = null)
        {
            var __workflow_htmlContent = WorkflowExpression.Compile(htmlContent, nameof(htmlContent), required: false);
            var __workflow_xCustomHost = WorkflowExpression.Compile(xCustomHost, nameof(xCustomHost), required: false);
            return new DeferredBodyAction<Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/File/HtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_htmlContent != null)
                    callPayload.Queries["htmlContent"] = ExpressionConverter.Convert(__workflow_htmlContent);
                if (__workflow_xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(__workflow_xCustomHost);
                return new ApiConnectionAction<Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SwaggerThreeToTwo(Expression<Func<string>> swaggerUrl = null, Expression<Func<string>> xCustomHost = null)
        {
            var __workflow_swaggerUrl = WorkflowExpression.Compile(swaggerUrl, nameof(swaggerUrl), required: false);
            var __workflow_xCustomHost = WorkflowExpression.Compile(xCustomHost, nameof(xCustomHost), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/File/SwaggerThreeToTwo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_swaggerUrl != null)
                    callPayload.Queries["swaggerUrl"] = ExpressionConverter.Convert(__workflow_swaggerUrl);
                if (__workflow_xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(__workflow_xCustomHost);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response, ApiConnectionActionConfiguration> Evaluate(Expression<Func<string>> formula = null, Expression<Func<string>> xCustomHost = null)
        {
            var __workflow_formula = WorkflowExpression.Compile(formula, nameof(formula), required: false);
            var __workflow_xCustomHost = WorkflowExpression.Compile(xCustomHost, nameof(xCustomHost), required: false);
            return new DeferredBodyAction<Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Math/Evaluate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_formula != null)
                    callPayload.Queries["formula"] = ExpressionConverter.Convert(__workflow_formula);
                if (__workflow_xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(__workflow_xCustomHost);
                return new ApiConnectionAction<Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response, ApiConnectionActionConfiguration> Sum(Expression<Func<string>> xCustomHost = null, Expression<Func<string>> bodydata = null, Expression<Func<string>> bodypath = null)
        {
            var __workflow_xCustomHost = WorkflowExpression.Compile(xCustomHost, nameof(xCustomHost), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            var __workflow_bodypath = WorkflowExpression.Compile(bodypath, nameof(bodypath), required: false);
            return new DeferredBodyAction<Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Math/Sum";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(__workflow_xCustomHost);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (__workflow_bodypath != null)
                {
                    body["path"] = ExpressionConverter.ConvertO(__workflow_bodypath);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response, ApiConnectionActionConfiguration> RoundUp(Expression<Func<double>> input = null, Expression<Func<string>> xCustomHost = null)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: false);
            var __workflow_xCustomHost = WorkflowExpression.Compile(xCustomHost, nameof(xCustomHost), required: false);
            return new DeferredBodyAction<Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Math/RoundUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_input != null)
                    callPayload.Queries["input"] = ExpressionConverter.Convert(__workflow_input);
                if (__workflow_xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(__workflow_xCustomHost);
                return new ApiConnectionAction<Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response, ApiConnectionActionConfiguration> Regex(Expression<Func<string>> xCustomHost = null, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodypattern = null)
        {
            var __workflow_xCustomHost = WorkflowExpression.Compile(xCustomHost, nameof(xCustomHost), required: false);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodypattern = WorkflowExpression.Compile(bodypattern, nameof(bodypattern), required: false);
            return new DeferredBodyAction<Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Text/Regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(__workflow_xCustomHost);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodypattern != null)
                {
                    body["pattern"] = ExpressionConverter.ConvertO(__workflow_bodypattern);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Response>(callPayload);
            });
        }
    }

    public class MeekouTriggers([ConnectionName] string connectionId)
    {
    }

    public class Response
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public ErrorInfo Error { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }
    }

    public class ErrorInfo
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Meekou;

    public partial class WorkflowManagedActions
    {
        public MeekouActions Meekou(string connectionId) => new MeekouActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MeekouTriggers Meekou(string connectionId) => new MeekouTriggers(connectionId);
    }
}
