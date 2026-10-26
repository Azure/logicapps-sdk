//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Markdownconverter
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MarkdownconverterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToHtmlResponse, ApiConnectionActionConfiguration> MarkdownToHtml(Expression<Func<MarkdownToHtmlInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToHtmlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToHtmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToJsonResponse, ApiConnectionActionConfiguration> MarkdownToJson(Expression<Func<MarkdownToJsonInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToXmlResponse, ApiConnectionActionConfiguration> MarkdownToXml(Expression<Func<MarkdownToXmlInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToXmlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToXmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToPlainTextResponse, ApiConnectionActionConfiguration> MarkdownToPlainText(Expression<Func<MarkdownToPlainTextInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToPlainTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toPlainText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToPlainTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToCsvResponse, ApiConnectionActionConfiguration> MarkdownToCsv(Expression<Func<MarkdownToCsvInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToCsvResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToCsvResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToLaTeXResponse, ApiConnectionActionConfiguration> MarkdownToLaTeX(Expression<Func<MarkdownToLaTeXInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToLaTeXResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toLaTeX";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToLaTeXResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToAdaptiveCardResponse, ApiConnectionActionConfiguration> MarkdownToAdaptiveCard(Expression<Func<MarkdownToAdaptiveCardInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToAdaptiveCardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toAdaptiveCard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToAdaptiveCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToYamlResponse, ApiConnectionActionConfiguration> MarkdownToYaml(Expression<Func<MarkdownToYamlInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToYamlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toYaml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToYamlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToEmailResponse, ApiConnectionActionConfiguration> MarkdownToEmail(Expression<Func<MarkdownToEmailInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToSvgResponse, ApiConnectionActionConfiguration> MarkdownToSvg(Expression<Func<MarkdownToSvgInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToSvgResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toSvg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToSvgResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToRssResponse, ApiConnectionActionConfiguration> MarkdownToRss(Expression<Func<MarkdownToRssInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToRssResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toRss";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToRssResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToWikiResponse, ApiConnectionActionConfiguration> MarkdownToWiki(Expression<Func<MarkdownToWikiInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToWikiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toWiki";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToWikiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToPngResponse, ApiConnectionActionConfiguration> MarkdownToPng(Expression<Func<MarkdownToPngInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToPngResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toPng";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToPngResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToChartResponse, ApiConnectionActionConfiguration> MarkdownToChart(Expression<Func<MarkdownToChartInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToChartResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toChart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToChartResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToDiagramResponse, ApiConnectionActionConfiguration> MarkdownToDiagram(Expression<Func<MarkdownToDiagramInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToDiagramResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toDiagram";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToDiagramResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownStatsResponse, ApiConnectionActionConfiguration> MarkdownStats(Expression<Func<MarkdownStatsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/statistics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToQrResponse, ApiConnectionActionConfiguration> MarkdownToQr(Expression<Func<MarkdownToQrInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToQrResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toQr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToQrResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToJpegResponse, ApiConnectionActionConfiguration> MarkdownToJpeg(Expression<Func<MarkdownToJpegInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToJpegResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toJpeg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToJpegResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToBadgeResponse, ApiConnectionActionConfiguration> MarkdownToBadge(Expression<Func<MarkdownToBadgeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToBadgeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toBadge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToBadgeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToInfographicResponse, ApiConnectionActionConfiguration> MarkdownToInfographic(Expression<Func<MarkdownToInfographicInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToInfographicResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toInfographic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToInfographicResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToLogResponse, ApiConnectionActionConfiguration> MarkdownToLog(Expression<Func<MarkdownToLogInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toLog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToLogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToMetricsResponse, ApiConnectionActionConfiguration> MarkdownToMetrics(Expression<Func<MarkdownToMetricsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToMetricsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toMetrics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToMetricsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToSyslogResponse, ApiConnectionActionConfiguration> MarkdownToSyslog(Expression<Func<MarkdownToSyslogInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToSyslogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toSyslog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToSyslogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToJsDocResponse, ApiConnectionActionConfiguration> MarkdownToJsDoc(Expression<Func<MarkdownToJsDocInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToJsDocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toJsDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToJsDocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToXmlDocResponse, ApiConnectionActionConfiguration> MarkdownToXmlDoc(Expression<Func<MarkdownToXmlDocInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToXmlDocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toXmlDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToXmlDocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToReadmeResponse, ApiConnectionActionConfiguration> MarkdownToReadme(Expression<Func<MarkdownToReadmeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToReadmeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toReadme";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToReadmeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToChangelogResponse, ApiConnectionActionConfiguration> MarkdownToChangelog(Expression<Func<MarkdownToChangelogInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToChangelogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toChangelog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToChangelogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToTableOfContentsResponse, ApiConnectionActionConfiguration> MarkdownToTableOfContents(Expression<Func<MarkdownToTableOfContentsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToTableOfContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toTableOfContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToTableOfContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToStyledHtmlResponse, ApiConnectionActionConfiguration> MarkdownToStyledHtml(Expression<Func<MarkdownToStyledHtmlInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkdownToStyledHtmlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/toStyledHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkdownToStyledHtmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownInfoResponse, ApiConnectionActionConfiguration> MarkdownInfo()
        {
            return new DeferredBodyAction<MarkdownInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MarkdownInfoResponse>(callPayload);
            });
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

    public class MarkdownToHtmlInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToJsonInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToXmlInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToPlainTextInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToCsvInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToLaTeXInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToAdaptiveCardInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToYamlInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToEmailInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToSvgInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToRssInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToWikiInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToPngInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToChartInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToDiagramInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownStatsInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToQrInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToJpegInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToBadgeInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToInfographicInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToLogInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToMetricsInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToSyslogInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToJsDocInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToXmlDocInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToReadmeInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToChangelogInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToTableOfContentsInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }
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

    public class MarkdownToStyledHtmlInput
    {
        [JsonProperty("markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarkdownContent { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }
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