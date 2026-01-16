//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Meekou
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MeekouActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response> HtmlToPdf(Expression<Func<string>> htmlContent = null, Expression<Func<string>> xCustomHost = null)
        {
            var apiCallPath = "/api/File/HtmlToPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (htmlContent != null)
                callPayload.Queries["htmlContent"] = ExpressionConverter.Convert(htmlContent);
            if (xCustomHost != null)
                callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(xCustomHost);
            return new ApiConnectionAction<Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IWorkflowAction SwaggerThreeToTwo(Expression<Func<string>> swaggerUrl = null, Expression<Func<string>> xCustomHost = null)
        {
            var apiCallPath = "/api/File/SwaggerThreeToTwo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (swaggerUrl != null)
                callPayload.Queries["swaggerUrl"] = ExpressionConverter.Convert(swaggerUrl);
            if (xCustomHost != null)
                callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(xCustomHost);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response> Evaluate(Expression<Func<string>> formula = null, Expression<Func<string>> xCustomHost = null)
        {
            var apiCallPath = "/api/Math/Evaluate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (formula != null)
                callPayload.Queries["formula"] = ExpressionConverter.Convert(formula);
            if (xCustomHost != null)
                callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(xCustomHost);
            return new ApiConnectionAction<Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response> Sum(Expression<Func<string>> xCustomHost = null, Expression<Func<string>> bodydata = null, Expression<Func<string>> bodypath = null)
        {
            var apiCallPath = "/api/Math/Sum";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xCustomHost != null)
                callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(xCustomHost);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydata != null)
            {
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                bodypropCount++;
            }

            if (bodypath != null)
            {
                body["path"] = ExpressionConverter.ConvertO(bodypath);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response> RoundUp(Expression<Func<double>> input = null, Expression<Func<string>> xCustomHost = null)
        {
            var apiCallPath = "/api/Math/RoundUp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (input != null)
                callPayload.Queries["input"] = ExpressionConverter.Convert(input);
            if (xCustomHost != null)
                callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(xCustomHost);
            return new ApiConnectionAction<Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response> Regex(Expression<Func<string>> xCustomHost = null, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodypattern = null)
        {
            var apiCallPath = "/api/Text/Regex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xCustomHost != null)
                callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(xCustomHost);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontent != null)
            {
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
            }

            if (bodypattern != null)
            {
                body["pattern"] = ExpressionConverter.ConvertO(bodypattern);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Response>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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