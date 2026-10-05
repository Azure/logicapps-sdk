//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Meekou
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MeekouActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        [WorkflowExpressionFactory(nameof(__BuildHtmlToPdf))]
        public IBodyWorkflowAction<Response> HtmlToPdf([WorkflowExpression] Func<string> htmlContent = null, [WorkflowExpression] Func<string> xCustomHost = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Response> __BuildHtmlToPdf(WorkflowValue<string> htmlContent = null, WorkflowValue<string> xCustomHost = null)
        {
            WorkflowValue.Validate(htmlContent, nameof(htmlContent), required: false);
            WorkflowValue.Validate(xCustomHost, nameof(xCustomHost), required: false);
            return new DeferredBodyAction<Response>(() =>
            {
                var apiCallPath = "/api/File/HtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (htmlContent != null)
                    callPayload.Queries["htmlContent"] = ExpressionConverter.Convert(htmlContent);
                if (xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(xCustomHost);
                return new ApiConnectionAction<Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        [WorkflowExpressionFactory(nameof(__BuildSwaggerThreeToTwo))]
        public IWorkflowAction SwaggerThreeToTwo([WorkflowExpression] Func<string> swaggerUrl = null, [WorkflowExpression] Func<string> xCustomHost = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSwaggerThreeToTwo(WorkflowValue<string> swaggerUrl = null, WorkflowValue<string> xCustomHost = null)
        {
            WorkflowValue.Validate(swaggerUrl, nameof(swaggerUrl), required: false);
            WorkflowValue.Validate(xCustomHost, nameof(xCustomHost), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/File/SwaggerThreeToTwo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (swaggerUrl != null)
                    callPayload.Queries["swaggerUrl"] = ExpressionConverter.Convert(swaggerUrl);
                if (xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(xCustomHost);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        [WorkflowExpressionFactory(nameof(__BuildEvaluate))]
        public IBodyWorkflowAction<Response> Evaluate([WorkflowExpression] Func<string> formula = null, [WorkflowExpression] Func<string> xCustomHost = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Response> __BuildEvaluate(WorkflowValue<string> formula = null, WorkflowValue<string> xCustomHost = null)
        {
            WorkflowValue.Validate(formula, nameof(formula), required: false);
            WorkflowValue.Validate(xCustomHost, nameof(xCustomHost), required: false);
            return new DeferredBodyAction<Response>(() =>
            {
                var apiCallPath = "/api/Math/Evaluate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (formula != null)
                    callPayload.Queries["formula"] = ExpressionConverter.Convert(formula);
                if (xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(xCustomHost);
                return new ApiConnectionAction<Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        [WorkflowExpressionFactory(nameof(__BuildSum))]
        public IBodyWorkflowAction<Response> Sum([WorkflowExpression] Func<string> xCustomHost = null, [WorkflowExpression] Func<string> bodydata = null, [WorkflowExpression] Func<string> bodypath = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Response> __BuildSum(WorkflowValue<string> xCustomHost = null, WorkflowValue<string> bodydata = null, WorkflowValue<string> bodypath = null)
        {
            WorkflowValue.Validate(xCustomHost, nameof(xCustomHost), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            WorkflowValue.Validate(bodypath, nameof(bodypath), required: false);
            return new DeferredBodyAction<Response>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        [WorkflowExpressionFactory(nameof(__BuildRoundUp))]
        public IBodyWorkflowAction<Response> RoundUp([WorkflowExpression] Func<double> input = null, [WorkflowExpression] Func<string> xCustomHost = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Response> __BuildRoundUp(WorkflowValue<double> input = null, WorkflowValue<string> xCustomHost = null)
        {
            WorkflowValue.Validate(input, nameof(input), required: false);
            WorkflowValue.Validate(xCustomHost, nameof(xCustomHost), required: false);
            return new DeferredBodyAction<Response>(() =>
            {
                var apiCallPath = "/api/Math/RoundUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (input != null)
                    callPayload.Queries["input"] = ExpressionConverter.Convert(input);
                if (xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = ExpressionConverter.Convert(xCustomHost);
                return new ApiConnectionAction<Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        [WorkflowExpressionFactory(nameof(__BuildRegex))]
        public IBodyWorkflowAction<Response> Regex([WorkflowExpression] Func<string> xCustomHost = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodypattern = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Response> __BuildRegex(WorkflowValue<string> xCustomHost = null, WorkflowValue<string> bodycontent = null, WorkflowValue<string> bodypattern = null)
        {
            WorkflowValue.Validate(xCustomHost, nameof(xCustomHost), required: false);
            WorkflowValue.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowValue.Validate(bodypattern, nameof(bodypattern), required: false);
            return new DeferredBodyAction<Response>(() =>
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
