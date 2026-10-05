//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Markdownconverter
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MarkdownconverterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToHtml))]
        public IBodyWorkflowAction<MarkdownToHtmlResponse> MarkdownToHtml([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToHtmlResponse> __BuildMarkdownToHtml(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToHtmlResponse>(() =>
            {
                var apiCallPath = "/convert/toHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToHtmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToJson))]
        public IBodyWorkflowAction<MarkdownToJsonResponse> MarkdownToJson([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToJsonResponse> __BuildMarkdownToJson(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToJsonResponse>(() =>
            {
                var apiCallPath = "/convert/toJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToXml))]
        public IBodyWorkflowAction<MarkdownToXmlResponse> MarkdownToXml([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToXmlResponse> __BuildMarkdownToXml(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToXmlResponse>(() =>
            {
                var apiCallPath = "/convert/toXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToXmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToPlainText))]
        public IBodyWorkflowAction<MarkdownToPlainTextResponse> MarkdownToPlainText([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToPlainTextResponse> __BuildMarkdownToPlainText(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToPlainTextResponse>(() =>
            {
                var apiCallPath = "/convert/toPlainText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToPlainTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToCsv))]
        public IBodyWorkflowAction<MarkdownToCsvResponse> MarkdownToCsv([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToCsvResponse> __BuildMarkdownToCsv(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToCsvResponse>(() =>
            {
                var apiCallPath = "/convert/toCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToCsvResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToLaTeX))]
        public IBodyWorkflowAction<MarkdownToLaTeXResponse> MarkdownToLaTeX([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToLaTeXResponse> __BuildMarkdownToLaTeX(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToLaTeXResponse>(() =>
            {
                var apiCallPath = "/convert/toLaTeX";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToLaTeXResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToAdaptiveCard))]
        public IBodyWorkflowAction<MarkdownToAdaptiveCardResponse> MarkdownToAdaptiveCard([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToAdaptiveCardResponse> __BuildMarkdownToAdaptiveCard(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToAdaptiveCardResponse>(() =>
            {
                var apiCallPath = "/convert/toAdaptiveCard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToAdaptiveCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToYaml))]
        public IBodyWorkflowAction<MarkdownToYamlResponse> MarkdownToYaml([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToYamlResponse> __BuildMarkdownToYaml(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToYamlResponse>(() =>
            {
                var apiCallPath = "/convert/toYaml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToYamlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToEmail))]
        public IBodyWorkflowAction<MarkdownToEmailResponse> MarkdownToEmail([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToEmailResponse> __BuildMarkdownToEmail(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToEmailResponse>(() =>
            {
                var apiCallPath = "/convert/toEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToSvg))]
        public IBodyWorkflowAction<MarkdownToSvgResponse> MarkdownToSvg([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToSvgResponse> __BuildMarkdownToSvg(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToSvgResponse>(() =>
            {
                var apiCallPath = "/convert/toSvg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToSvgResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToRss))]
        public IBodyWorkflowAction<MarkdownToRssResponse> MarkdownToRss([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToRssResponse> __BuildMarkdownToRss(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToRssResponse>(() =>
            {
                var apiCallPath = "/convert/toRss";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToRssResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToWiki))]
        public IBodyWorkflowAction<MarkdownToWikiResponse> MarkdownToWiki([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToWikiResponse> __BuildMarkdownToWiki(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToWikiResponse>(() =>
            {
                var apiCallPath = "/convert/toWiki";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToWikiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToPng))]
        public IBodyWorkflowAction<MarkdownToPngResponse> MarkdownToPng([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToPngResponse> __BuildMarkdownToPng(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToPngResponse>(() =>
            {
                var apiCallPath = "/convert/toPng";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToPngResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToChart))]
        public IBodyWorkflowAction<MarkdownToChartResponse> MarkdownToChart([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToChartResponse> __BuildMarkdownToChart(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToChartResponse>(() =>
            {
                var apiCallPath = "/convert/toChart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToChartResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToDiagram))]
        public IBodyWorkflowAction<MarkdownToDiagramResponse> MarkdownToDiagram([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToDiagramResponse> __BuildMarkdownToDiagram(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToDiagramResponse>(() =>
            {
                var apiCallPath = "/convert/toDiagram";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToDiagramResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownStats))]
        public IBodyWorkflowAction<MarkdownStatsResponse> MarkdownStats([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownStatsResponse> __BuildMarkdownStats(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownStatsResponse>(() =>
            {
                var apiCallPath = "/statistics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToQr))]
        public IBodyWorkflowAction<MarkdownToQrResponse> MarkdownToQr([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToQrResponse> __BuildMarkdownToQr(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToQrResponse>(() =>
            {
                var apiCallPath = "/convert/toQr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToQrResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToJpeg))]
        public IBodyWorkflowAction<MarkdownToJpegResponse> MarkdownToJpeg([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToJpegResponse> __BuildMarkdownToJpeg(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToJpegResponse>(() =>
            {
                var apiCallPath = "/convert/toJpeg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToJpegResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToBadge))]
        public IBodyWorkflowAction<MarkdownToBadgeResponse> MarkdownToBadge([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToBadgeResponse> __BuildMarkdownToBadge(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToBadgeResponse>(() =>
            {
                var apiCallPath = "/convert/toBadge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToBadgeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToInfographic))]
        public IBodyWorkflowAction<MarkdownToInfographicResponse> MarkdownToInfographic([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToInfographicResponse> __BuildMarkdownToInfographic(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToInfographicResponse>(() =>
            {
                var apiCallPath = "/convert/toInfographic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToInfographicResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToLog))]
        public IBodyWorkflowAction<MarkdownToLogResponse> MarkdownToLog([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToLogResponse> __BuildMarkdownToLog(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToLogResponse>(() =>
            {
                var apiCallPath = "/convert/toLog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToLogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToMetrics))]
        public IBodyWorkflowAction<MarkdownToMetricsResponse> MarkdownToMetrics([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToMetricsResponse> __BuildMarkdownToMetrics(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToMetricsResponse>(() =>
            {
                var apiCallPath = "/convert/toMetrics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToMetricsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToSyslog))]
        public IBodyWorkflowAction<MarkdownToSyslogResponse> MarkdownToSyslog([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToSyslogResponse> __BuildMarkdownToSyslog(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToSyslogResponse>(() =>
            {
                var apiCallPath = "/convert/toSyslog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToSyslogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToJsDoc))]
        public IBodyWorkflowAction<MarkdownToJsDocResponse> MarkdownToJsDoc([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToJsDocResponse> __BuildMarkdownToJsDoc(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToJsDocResponse>(() =>
            {
                var apiCallPath = "/convert/toJsDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToJsDocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToXmlDoc))]
        public IBodyWorkflowAction<MarkdownToXmlDocResponse> MarkdownToXmlDoc([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToXmlDocResponse> __BuildMarkdownToXmlDoc(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToXmlDocResponse>(() =>
            {
                var apiCallPath = "/convert/toXmlDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToXmlDocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToReadme))]
        public IBodyWorkflowAction<MarkdownToReadmeResponse> MarkdownToReadme([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToReadmeResponse> __BuildMarkdownToReadme(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToReadmeResponse>(() =>
            {
                var apiCallPath = "/convert/toReadme";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToReadmeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToChangelog))]
        public IBodyWorkflowAction<MarkdownToChangelogResponse> MarkdownToChangelog([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToChangelogResponse> __BuildMarkdownToChangelog(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToChangelogResponse>(() =>
            {
                var apiCallPath = "/convert/toChangelog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToChangelogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToTableOfContents))]
        public IBodyWorkflowAction<MarkdownToTableOfContentsResponse> MarkdownToTableOfContents([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToTableOfContentsResponse> __BuildMarkdownToTableOfContents(WorkflowValue<string> bodymarkdownContent)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            return new DeferredBodyAction<MarkdownToTableOfContentsResponse>(() =>
            {
                var apiCallPath = "/convert/toTableOfContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToTableOfContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        [WorkflowExpressionFactory(nameof(__BuildMarkdownToStyledHtml))]
        public IBodyWorkflowAction<MarkdownToStyledHtmlResponse> MarkdownToStyledHtml([WorkflowExpression] Func<string> bodymarkdownContent, [WorkflowExpression] Func<string> bodytheme = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkdownToStyledHtmlResponse> __BuildMarkdownToStyledHtml(WorkflowValue<string> bodymarkdownContent, WorkflowValue<string> bodytheme = null)
        {
            WorkflowValue.Validate(bodymarkdownContent, nameof(bodymarkdownContent), required: true);
            WorkflowValue.Validate(bodytheme, nameof(bodytheme), required: false);
            return new DeferredBodyAction<MarkdownToStyledHtmlResponse>(() =>
            {
                var apiCallPath = "/convert/toStyledHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdownContent);
                if (bodytheme != null)
                {
                    body["theme"] = ExpressionConverter.ConvertO(bodytheme);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkdownToStyledHtmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownInfoResponse> MarkdownInfo()
        {
            var apiCallPath = "/info";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MarkdownInfoResponse>(callPayload);
        }
    }

    public class MarkdownconverterTriggers([ConnectionName] string connectionId)
    {
    }

    public class MarkdownToHtmlResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("html")]
        public string HTMLOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToJsonResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("structuredData")]
        public JToken JSONOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToXmlResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("xml")]
        public string XMLOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToPlainTextResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("plainText")]
        public string PlainTextOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToCsvResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("csv")]
        public string CSVOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToLaTeXResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("latex")]
        public string LaTeXOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToAdaptiveCardResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("adaptiveCard")]
        public JToken AdaptiveCardOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToYamlResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("yaml")]
        public string YAMLOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToEmailResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("emailHtml")]
        public string EmailHTMLOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToSvgResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("svg")]
        public string SVGOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToRssResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("rss")]
        public string RSSOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToWikiResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("wikiMarkup")]
        public string WikiMarkupOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToPngResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("pngBase64")]
        public string PNGBase64 { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToChartResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("chartBase64")]
        public string ChartBase64 { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToDiagramResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("diagramBase64")]
        public string DiagramBase64 { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownStatsResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("statistics")]
        public MarkdownStatsResponseStatisticsType Statistics { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string AnalysisTime { get; set; }
    }

    public class MarkdownStatsResponseStatisticsType
    {
        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("wordCount")]
        public int WordCount { get; set; }

        [JsonProperty("lineCount")]
        public int LineCount { get; set; }

        [JsonProperty("paragraphCount")]
        public int ParagraphCount { get; set; }

        [JsonProperty("headingCount")]
        public int HeadingCount { get; set; }

        [JsonProperty("linkCount")]
        public int LinkCount { get; set; }

        [JsonProperty("imageCount")]
        public int ImageCount { get; set; }

        [JsonProperty("tableCount")]
        public int TableCount { get; set; }

        [JsonProperty("codeBlockCount")]
        public int CodeBlockCount { get; set; }
    }

    public class MarkdownToQrResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("qrBase64")]
        public string QRBase64 { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToJpegResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("jpegBase64")]
        public string JPEGBase64 { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToBadgeResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("badgeBase64")]
        public string BadgeBase64 { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToInfographicResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("infographicBase64")]
        public string InfographicBase64 { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToLogResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("logOutput")]
        public string LogOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToMetricsResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("metricsOutput")]
        public string MetricsOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToSyslogResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("syslogOutput")]
        public string SyslogOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToJsDocResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("jsDoc")]
        public string JSDocOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToXmlDocResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("xmlDoc")]
        public string XMLDocumentationOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToReadmeResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("readme")]
        public string READMEOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToChangelogResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("changelog")]
        public string ChangelogOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownToTableOfContentsResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("tableOfContents")]
        public string TableOfContents { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string GenerationTime { get; set; }
    }

    public class MarkdownToStyledHtmlResponse
    {
        [JsonProperty("originalMarkdown")]
        public string OriginalMarkdown { get; set; }

        [JsonProperty("styledHtml")]
        public string StyledHTMLOutput { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("timestamp")]
        public string ConversionTime { get; set; }
    }

    public class MarkdownInfoResponse
    {
        [JsonProperty("name")]
        public string ConverterName { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("supportedFormats")]
        public string[] SupportedFormats { get; set; }

        [JsonProperty("capabilities")]
        public string[] Capabilities { get; set; }

        [JsonProperty("timestamp")]
        public string RequestTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Markdownconverter;

    public partial class WorkflowManagedActions
    {
        public MarkdownconverterActions Markdownconverter(string connectionId) => new MarkdownconverterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MarkdownconverterTriggers Markdownconverter(string connectionId) => new MarkdownconverterTriggers(connectionId);
    }
}
