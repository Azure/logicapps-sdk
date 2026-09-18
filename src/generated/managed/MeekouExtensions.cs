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
        public IBodyWorkflowAction<Response> HtmlToPdf([WorkflowExpression] Func<string> htmlContent = null, [WorkflowExpression] Func<string> xCustomHost = null)
        {
            SourceExpression.Validate(htmlContent, nameof(htmlContent), required: false);
            SourceExpression.Validate(xCustomHost, nameof(xCustomHost), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/File/HtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (htmlContent != null)
                    callPayload.Queries["htmlContent"] = SourceExpressionConverter.ConvertO(htmlContent);
                if (xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = SourceExpressionConverter.ConvertO(xCustomHost);
                return callPayload;
            }

            return new ApiConnectionAction<Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IWorkflowAction SwaggerThreeToTwo([WorkflowExpression] Func<string> swaggerUrl = null, [WorkflowExpression] Func<string> xCustomHost = null)
        {
            SourceExpression.Validate(swaggerUrl, nameof(swaggerUrl), required: false);
            SourceExpression.Validate(xCustomHost, nameof(xCustomHost), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/File/SwaggerThreeToTwo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (swaggerUrl != null)
                    callPayload.Queries["swaggerUrl"] = SourceExpressionConverter.ConvertO(swaggerUrl);
                if (xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = SourceExpressionConverter.ConvertO(xCustomHost);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response> Evaluate([WorkflowExpression] Func<string> formula = null, [WorkflowExpression] Func<string> xCustomHost = null)
        {
            SourceExpression.Validate(formula, nameof(formula), required: false);
            SourceExpression.Validate(xCustomHost, nameof(xCustomHost), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Math/Evaluate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (formula != null)
                    callPayload.Queries["formula"] = SourceExpressionConverter.ConvertO(formula);
                if (xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = SourceExpressionConverter.ConvertO(xCustomHost);
                return callPayload;
            }

            return new ApiConnectionAction<Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response> Sum([WorkflowExpression] Func<string> xCustomHost = null, [WorkflowExpression] Func<string> bodydata = null, [WorkflowExpression] Func<string> bodypath = null)
        {
            SourceExpression.Validate(xCustomHost, nameof(xCustomHost), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            SourceExpression.Validate(bodypath, nameof(bodypath), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Math/Sum";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = SourceExpressionConverter.ConvertO(xCustomHost);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypath != null)
                {
                    body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response> RoundUp([WorkflowExpression] Func<double> input = null, [WorkflowExpression] Func<string> xCustomHost = null)
        {
            SourceExpression.Validate(input, nameof(input), required: false);
            SourceExpression.Validate(xCustomHost, nameof(xCustomHost), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Math/RoundUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (input != null)
                    callPayload.Queries["input"] = SourceExpressionConverter.ConvertO(input);
                if (xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = SourceExpressionConverter.ConvertO(xCustomHost);
                return callPayload;
            }

            return new ApiConnectionAction<Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meekou")]
        public IBodyWorkflowAction<Response> Regex([WorkflowExpression] Func<string> xCustomHost = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodypattern = null)
        {
            SourceExpression.Validate(xCustomHost, nameof(xCustomHost), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodypattern, nameof(bodypattern), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Text/Regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xCustomHost != null)
                    callPayload.Headers["x-custom-host"] = SourceExpressionConverter.ConvertO(xCustomHost);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodypattern != null)
                {
                    body["pattern"] = SourceExpressionConverter.ConvertToken(bodypattern);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Response>(BuildSourceInput);
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