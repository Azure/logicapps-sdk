//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Markdownconverter
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MarkdownconverterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToHtmlResponse> MarkdownToHtml(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToJsonResponse> MarkdownToJson(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToXmlResponse> MarkdownToXml(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToPlainTextResponse> MarkdownToPlainText(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToCsvResponse> MarkdownToCsv(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToLaTeXResponse> MarkdownToLaTeX(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToAdaptiveCardResponse> MarkdownToAdaptiveCard(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToYamlResponse> MarkdownToYaml(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToEmailResponse> MarkdownToEmail(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToSvgResponse> MarkdownToSvg(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToRssResponse> MarkdownToRss(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToWikiResponse> MarkdownToWiki(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToPngResponse> MarkdownToPng(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToChartResponse> MarkdownToChart(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToDiagramResponse> MarkdownToDiagram(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownStatsResponse> MarkdownStats(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToQrResponse> MarkdownToQr(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToJpegResponse> MarkdownToJpeg(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToBadgeResponse> MarkdownToBadge(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToInfographicResponse> MarkdownToInfographic(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToLogResponse> MarkdownToLog(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToMetricsResponse> MarkdownToMetrics(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToSyslogResponse> MarkdownToSyslog(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToJsDocResponse> MarkdownToJsDoc(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToXmlDocResponse> MarkdownToXmlDoc(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToReadmeResponse> MarkdownToReadme(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToChangelogResponse> MarkdownToChangelog(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToTableOfContentsResponse> MarkdownToTableOfContents(Expression<Func<string>> bodymarkdownContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToStyledHtmlResponse> MarkdownToStyledHtml(Expression<Func<string>> bodymarkdownContent, Expression<Func<string>> bodytheme = null)
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
    using Microsoft.Azure.Workflows.Sdk.Markdownconverter;

    public partial class WorkflowManagedActions
    {
        public MarkdownconverterActions Markdownconverter(string connectionId) => new MarkdownconverterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MarkdownconverterTriggers Markdownconverter(string connectionId) => new MarkdownconverterTriggers(connectionId);
    }
}