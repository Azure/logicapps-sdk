//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Markdownconverter
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MarkdownconverterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToHtmlResponse> MarkdownToHtml([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToHtmlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToJsonResponse> MarkdownToJson([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToJsonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToXmlResponse> MarkdownToXml([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToXmlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToPlainTextResponse> MarkdownToPlainText([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toPlainText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToPlainTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToCsvResponse> MarkdownToCsv([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToCsvResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToLaTeXResponse> MarkdownToLaTeX([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toLaTeX";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToLaTeXResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToAdaptiveCardResponse> MarkdownToAdaptiveCard([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toAdaptiveCard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToAdaptiveCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToYamlResponse> MarkdownToYaml([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toYaml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToYamlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToEmailResponse> MarkdownToEmail([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToSvgResponse> MarkdownToSvg([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toSvg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToSvgResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToRssResponse> MarkdownToRss([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toRss";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToRssResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToWikiResponse> MarkdownToWiki([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toWiki";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToWikiResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToPngResponse> MarkdownToPng([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toPng";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToPngResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToChartResponse> MarkdownToChart([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toChart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToChartResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToDiagramResponse> MarkdownToDiagram([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toDiagram";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToDiagramResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownStatsResponse> MarkdownStats([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/statistics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownStatsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToQrResponse> MarkdownToQr([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toQr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToQrResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToJpegResponse> MarkdownToJpeg([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toJpeg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToJpegResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToBadgeResponse> MarkdownToBadge([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toBadge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToBadgeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToInfographicResponse> MarkdownToInfographic([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toInfographic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToInfographicResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToLogResponse> MarkdownToLog([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toLog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToLogResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToMetricsResponse> MarkdownToMetrics([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toMetrics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToMetricsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToSyslogResponse> MarkdownToSyslog([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toSyslog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToSyslogResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToJsDocResponse> MarkdownToJsDoc([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toJsDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToJsDocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToXmlDocResponse> MarkdownToXmlDoc([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toXmlDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToXmlDocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToReadmeResponse> MarkdownToReadme([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toReadme";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToReadmeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToChangelogResponse> MarkdownToChangelog([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toChangelog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToChangelogResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToTableOfContentsResponse> MarkdownToTableOfContents([WorkflowExpression] Func<string> bodymarkdownContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toTableOfContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToTableOfContentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownToStyledHtmlResponse> MarkdownToStyledHtml([WorkflowExpression] Func<string> bodymarkdownContent, [WorkflowExpression] Func<string> bodytheme = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/toStyledHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdownContent);
                if (bodytheme != null)
                {
                    body["theme"] = SourceExpressionConverter.ConvertToken(bodytheme);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownToStyledHtmlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "markdownconverter")]
        public IBodyWorkflowAction<MarkdownInfoResponse> MarkdownInfo()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MarkdownInfoResponse>(BuildSourceInput);
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