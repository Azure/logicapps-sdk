//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfcoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<HtmlToPdfResponse> HtmlToPdf([WorkflowExpression] Func<string> bodyhtml, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymargins = null, [WorkflowExpression] Func<bodypaperSizeInput> bodypaperSize = null, [WorkflowExpression] Func<bodyorientationInput> bodyorientation = null, [WorkflowExpression] Func<bool> bodyprintBackground = null, [WorkflowExpression] Func<string> bodyheader = null, [WorkflowExpression] Func<string> bodyfooter = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyhtml, nameof(bodyhtml), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodymargins, nameof(bodymargins), required: false);
            SourceExpression.Validate(bodypaperSize, nameof(bodypaperSize), required: false);
            SourceExpression.Validate(bodyorientation, nameof(bodyorientation), required: false);
            SourceExpression.Validate(bodyprintBackground, nameof(bodyprintBackground), required: false);
            SourceExpression.Validate(bodyheader, nameof(bodyheader), required: false);
            SourceExpression.Validate(bodyfooter, nameof(bodyfooter), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/from/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["html"] = SourceExpressionConverter.ConvertToken(bodyhtml);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodymargins != null)
                {
                    if (bodymargins != null)
                    {
                        body["margins"] = SourceExpressionConverter.ConvertToken(bodymargins);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["margins"] = "5px 5px 5px 5px";
                    bodypropCount++;
                }

                if (bodypaperSize != null)
                {
                    if (bodypaperSize != null)
                    {
                        body["paperSize"] = SourceExpressionConverter.Convert(bodypaperSize);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["paperSize"] = "Letter";
                    bodypropCount++;
                }

                if (bodyorientation != null)
                {
                    if (bodyorientation != null)
                    {
                        body["orientation"] = SourceExpressionConverter.Convert(bodyorientation);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["orientation"] = "portrait";
                    bodypropCount++;
                }

                if (bodyprintBackground != null)
                {
                    if (bodyprintBackground != null)
                    {
                        body["printBackground"] = SourceExpressionConverter.ConvertToken(bodyprintBackground);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["printBackground"] = true;
                    bodypropCount++;
                }

                if (bodyheader != null)
                {
                    body["header"] = SourceExpressionConverter.ConvertToken(bodyheader);
                    bodypropCount++;
                }

                if (bodyfooter != null)
                {
                    body["footer"] = SourceExpressionConverter.ConvertToken(bodyfooter);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HtmlToPdfResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<UrlToPdfResponse> UrlToPdf([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodymargins = null, [WorkflowExpression] Func<string> bodypaperSize = null, [WorkflowExpression] Func<bodyorientationInput> bodyorientation = null, [WorkflowExpression] Func<bool> bodyprintBackground = null, [WorkflowExpression] Func<string> bodyheader = null, [WorkflowExpression] Func<string> bodyfooter = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodymargins, nameof(bodymargins), required: false);
            SourceExpression.Validate(bodypaperSize, nameof(bodypaperSize), required: false);
            SourceExpression.Validate(bodyorientation, nameof(bodyorientation), required: false);
            SourceExpression.Validate(bodyprintBackground, nameof(bodyprintBackground), required: false);
            SourceExpression.Validate(bodyheader, nameof(bodyheader), required: false);
            SourceExpression.Validate(bodyfooter, nameof(bodyfooter), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/from/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodymargins != null)
                {
                    if (bodymargins != null)
                    {
                        body["margins"] = SourceExpressionConverter.ConvertToken(bodymargins);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["margins"] = "5mm";
                    bodypropCount++;
                }

                if (bodypaperSize != null)
                {
                    if (bodypaperSize != null)
                    {
                        body["paperSize"] = SourceExpressionConverter.ConvertToken(bodypaperSize);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["paperSize"] = "Letter";
                    bodypropCount++;
                }

                if (bodyorientation != null)
                {
                    if (bodyorientation != null)
                    {
                        body["orientation"] = SourceExpressionConverter.Convert(bodyorientation);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["orientation"] = "Portrait";
                    bodypropCount++;
                }

                if (bodyprintBackground != null)
                {
                    if (bodyprintBackground != null)
                    {
                        body["printBackground"] = SourceExpressionConverter.ConvertToken(bodyprintBackground);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["printBackground"] = true;
                    bodypropCount++;
                }

                if (bodyheader != null)
                {
                    body["header"] = SourceExpressionConverter.ConvertToken(bodyheader);
                    bodypropCount++;
                }

                if (bodyfooter != null)
                {
                    body["footer"] = SourceExpressionConverter.ConvertToken(bodyfooter);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UrlToPdfResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PdfFillerResponse> PdfFiller([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyannotationsString = null, [WorkflowExpression] Func<string> bodyimagesString = null, [WorkflowExpression] Func<string> bodyfieldsString = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyannotationsString, nameof(bodyannotationsString), required: false);
            SourceExpression.Validate(bodyimagesString, nameof(bodyimagesString), required: false);
            SourceExpression.Validate(bodyfieldsString, nameof(bodyfieldsString), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/edit/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyannotationsString != null)
                {
                    body["annotationsString"] = SourceExpressionConverter.ConvertToken(bodyannotationsString);
                    bodypropCount++;
                }

                if (bodyimagesString != null)
                {
                    body["imagesString"] = SourceExpressionConverter.ConvertToken(bodyimagesString);
                    bodypropCount++;
                }

                if (bodyfieldsString != null)
                {
                    body["fieldsString"] = SourceExpressionConverter.ConvertToken(bodyfieldsString);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PdfFillerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<MergePdfSimplifiedResponse> MergePdfSimplified([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MergePdfSimplifiedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<MergePdfResponse> MergePdf([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/merge2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MergePdfResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SplitPdfResponse> SplitPdf([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodypages, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: true);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SplitPdfResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SplitPdf2Response> SplitPdf2([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodysearchString, [WorkflowExpression] Func<bool> bodyexcludeKeyPages = null, [WorkflowExpression] Func<bool> bodyregexSearch = null, [WorkflowExpression] Func<bool> bodycaseSensitive = null, [WorkflowExpression] Func<string> bodylang = null, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodysearchString, nameof(bodysearchString), required: true);
            SourceExpression.Validate(bodyexcludeKeyPages, nameof(bodyexcludeKeyPages), required: false);
            SourceExpression.Validate(bodyregexSearch, nameof(bodyregexSearch), required: false);
            SourceExpression.Validate(bodycaseSensitive, nameof(bodycaseSensitive), required: false);
            SourceExpression.Validate(bodylang, nameof(bodylang), required: false);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/split2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["searchString"] = SourceExpressionConverter.ConvertToken(bodysearchString);
                if (bodyexcludeKeyPages != null)
                {
                    if (bodyexcludeKeyPages != null)
                    {
                        body["excludeKeyPages"] = SourceExpressionConverter.ConvertToken(bodyexcludeKeyPages);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["excludeKeyPages"] = false;
                    bodypropCount++;
                }

                if (bodyregexSearch != null)
                {
                    if (bodyregexSearch != null)
                    {
                        body["regexSearch"] = SourceExpressionConverter.ConvertToken(bodyregexSearch);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["regexSearch"] = false;
                    bodypropCount++;
                }

                if (bodycaseSensitive != null)
                {
                    if (bodycaseSensitive != null)
                    {
                        body["caseSensitive"] = SourceExpressionConverter.ConvertToken(bodycaseSensitive);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["caseSensitive"] = false;
                    bodypropCount++;
                }

                if (bodylang != null)
                {
                    if (bodylang != null)
                    {
                        body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["lang"] = "eng";
                    bodypropCount++;
                }

                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SplitPdf2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSerarchTextResponse> PDFSerarchText([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodysearchString, [WorkflowExpression] Func<bool> bodyregexSearch = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<bodywordMatchingModeInput> bodywordMatchingMode = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodysearchString, nameof(bodysearchString), required: true);
            SourceExpression.Validate(bodyregexSearch, nameof(bodyregexSearch), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodywordMatchingMode, nameof(bodywordMatchingMode), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["searchString"] = SourceExpressionConverter.ConvertToken(bodysearchString);
                if (bodyregexSearch != null)
                {
                    if (bodyregexSearch != null)
                    {
                        body["regexSearch"] = SourceExpressionConverter.ConvertToken(bodyregexSearch);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["regexSearch"] = false;
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodywordMatchingMode != null)
                {
                    body["wordMatchingMode"] = SourceExpressionConverter.Convert(bodywordMatchingMode);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFSerarchTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<DocumentParserResponse> DocumentParser([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat, [WorkflowExpression] Func<string> bodytemplateId = null, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: true);
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/documentparser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodytemplateId != null)
                {
                    body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["outputFormat"] = SourceExpressionConverter.Convert(bodyoutputFormat);
                if (bodyinline != null)
                {
                    body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentParserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<JobCheckResponse> JobCheck([WorkflowExpression] Func<string> bodyjobid)
        {
            SourceExpression.Validate(bodyjobid, nameof(bodyjobid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/job/check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["jobid"] = SourceExpressionConverter.ConvertToken(bodyjobid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JobCheckResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<BarcodeGeneratorResponse> BarcodeGenerator([WorkflowExpression] Func<string> bodyvalue, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydecorationImage = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydecorationImage, nameof(bodydecorationImage), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/barcode/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodydecorationImage != null)
                {
                    body["decorationImage"] = SourceExpressionConverter.ConvertToken(bodydecorationImage);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BarcodeGeneratorResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<BarcodeReaderResponse> BarcodeReader([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodytypes, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodytypes, nameof(bodytypes), required: true);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/barcode/read/from/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["types"] = SourceExpressionConverter.ConvertToken(bodytypes);
                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BarcodeReaderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFInfoReaderResponse> PDFInfoReader([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/info";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFInfoReaderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFormsInfoReaderResponse> PDFFormsInfoReader([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/info/fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFFormsInfoReaderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFindTableResponse> PDFFindTable([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/find/table";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFFindTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndReplaceResponse> SearchAndReplace([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string[]> bodysearchStrings, [WorkflowExpression] Func<string[]> bodyreplaceStrings = null, [WorkflowExpression] Func<bool> bodycaseSensitive = null, [WorkflowExpression] Func<int> bodyreplacementLimit = null, [WorkflowExpression] Func<bool> bodyregex = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodysearchStrings, nameof(bodysearchStrings), required: true);
            SourceExpression.Validate(bodyreplaceStrings, nameof(bodyreplaceStrings), required: false);
            SourceExpression.Validate(bodycaseSensitive, nameof(bodycaseSensitive), required: false);
            SourceExpression.Validate(bodyreplacementLimit, nameof(bodyreplacementLimit), required: false);
            SourceExpression.Validate(bodyregex, nameof(bodyregex), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/edit/replace-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["searchStrings"] = SourceExpressionConverter.ConvertToken(bodysearchStrings);
                if (bodyreplaceStrings != null)
                {
                    body["replaceStrings"] = SourceExpressionConverter.ConvertToken(bodyreplaceStrings);
                    bodypropCount++;
                }

                if (bodycaseSensitive != null)
                {
                    body["caseSensitive"] = SourceExpressionConverter.ConvertToken(bodycaseSensitive);
                    bodypropCount++;
                }

                if (bodyreplacementLimit != null)
                {
                    body["replacementLimit"] = SourceExpressionConverter.ConvertToken(bodyreplacementLimit);
                    bodypropCount++;
                }

                if (bodyregex != null)
                {
                    body["regex"] = SourceExpressionConverter.ConvertToken(bodyregex);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchAndReplaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndReplaceWithImageResponse> SearchAndReplaceWithImage([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodysearchString, [WorkflowExpression] Func<string> bodyreplaceImage, [WorkflowExpression] Func<bool> bodycaseSensitive = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<bool> bodyregex = null, [WorkflowExpression] Func<int> bodyreplacementLimit = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodysearchString, nameof(bodysearchString), required: true);
            SourceExpression.Validate(bodyreplaceImage, nameof(bodyreplaceImage), required: true);
            SourceExpression.Validate(bodycaseSensitive, nameof(bodycaseSensitive), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyregex, nameof(bodyregex), required: false);
            SourceExpression.Validate(bodyreplacementLimit, nameof(bodyreplacementLimit), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/edit/replace-text-with-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodycaseSensitive != null)
                {
                    if (bodycaseSensitive != null)
                    {
                        body["caseSensitive"] = SourceExpressionConverter.ConvertToken(bodycaseSensitive);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["caseSensitive"] = false;
                    bodypropCount++;
                }

                bodypropCount++;
                body["searchString"] = SourceExpressionConverter.ConvertToken(bodysearchString);
                bodypropCount++;
                body["replaceImage"] = SourceExpressionConverter.ConvertToken(bodyreplaceImage);
                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyregex != null)
                {
                    if (bodyregex != null)
                    {
                        body["regex"] = SourceExpressionConverter.ConvertToken(bodyregex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["regex"] = false;
                    bodypropCount++;
                }

                if (bodyreplacementLimit != null)
                {
                    if (bodyreplacementLimit != null)
                    {
                        body["replacementLimit"] = SourceExpressionConverter.ConvertToken(bodyreplacementLimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["replacementLimit"] = 0;
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchAndReplaceWithImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndDeleteTextResponse> SearchAndDeleteText([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string[]> bodysearchStrings, [WorkflowExpression] Func<bool> bodycaseSensitive = null, [WorkflowExpression] Func<bool> bodyregex = null, [WorkflowExpression] Func<int> bodyreplacementLimit = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodysearchStrings, nameof(bodysearchStrings), required: true);
            SourceExpression.Validate(bodycaseSensitive, nameof(bodycaseSensitive), required: false);
            SourceExpression.Validate(bodyregex, nameof(bodyregex), required: false);
            SourceExpression.Validate(bodyreplacementLimit, nameof(bodyreplacementLimit), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/edit/delete-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["searchStrings"] = SourceExpressionConverter.ConvertToken(bodysearchStrings);
                if (bodycaseSensitive != null)
                {
                    if (bodycaseSensitive != null)
                    {
                        body["caseSensitive"] = SourceExpressionConverter.ConvertToken(bodycaseSensitive);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["caseSensitive"] = false;
                    bodypropCount++;
                }

                if (bodyregex != null)
                {
                    body["regex"] = SourceExpressionConverter.ConvertToken(bodyregex);
                    bodypropCount++;
                }

                if (bodyreplacementLimit != null)
                {
                    if (bodyreplacementLimit != null)
                    {
                        body["replacementLimit"] = SourceExpressionConverter.ConvertToken(bodyreplacementLimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["replacementLimit"] = 0;
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchAndDeleteTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSearchableResponse> PDFSearchable([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodylang = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodylang, nameof(bodylang), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/makesearchable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodylang != null)
                {
                    if (bodylang != null)
                    {
                        body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["lang"] = "eng";
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFSearchableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFUnSearchableResponse> PDFUnSearchable([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/makeunsearchable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFUnSearchableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToCSVResponse> PDFToCSV([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodylang = null, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<bodyunwrapInput> bodyunwrap = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylineGrouping = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodylang, nameof(bodylang), required: false);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodyunwrap, nameof(bodyunwrap), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodylineGrouping, nameof(bodylineGrouping), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodylang != null)
                {
                    body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                    bodypropCount++;
                }

                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodyunwrap != null)
                {
                    body["unwrap"] = SourceExpressionConverter.Convert(bodyunwrap);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodylineGrouping != null)
                {
                    body["lineGrouping"] = SourceExpressionConverter.ConvertToken(bodylineGrouping);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToCSVResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJSONResponse> PDFToJSON([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodylang = null, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<bodyunwrapInput> bodyunwrap = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylineGrouping = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodylang, nameof(bodylang), required: false);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodyunwrap, nameof(bodyunwrap), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodylineGrouping, nameof(bodylineGrouping), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/json2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodylang != null)
                {
                    body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                    bodypropCount++;
                }

                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodyunwrap != null)
                {
                    body["unwrap"] = SourceExpressionConverter.Convert(bodyunwrap);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodylineGrouping != null)
                {
                    body["lineGrouping"] = SourceExpressionConverter.ConvertToken(bodylineGrouping);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToJSONResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJSONMetaResponse> PDFToJSONMeta([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodylang = null, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<bodyunwrapInput> bodyunwrap = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylineGrouping = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodylang, nameof(bodylang), required: false);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodyunwrap, nameof(bodyunwrap), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodylineGrouping, nameof(bodylineGrouping), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/json-meta";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodylang != null)
                {
                    body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                    bodypropCount++;
                }

                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodyunwrap != null)
                {
                    body["unwrap"] = SourceExpressionConverter.Convert(bodyunwrap);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodylineGrouping != null)
                {
                    body["lineGrouping"] = SourceExpressionConverter.ConvertToken(bodylineGrouping);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToJSONMetaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTextResponse> PDFToText([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodylang = null, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<bodyunwrapInput> bodyunwrap = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylineGrouping = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodylang, nameof(bodylang), required: false);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodyunwrap, nameof(bodyunwrap), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodylineGrouping, nameof(bodylineGrouping), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodylang != null)
                {
                    body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                    bodypropCount++;
                }

                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodyunwrap != null)
                {
                    body["unwrap"] = SourceExpressionConverter.Convert(bodyunwrap);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodylineGrouping != null)
                {
                    body["lineGrouping"] = SourceExpressionConverter.ConvertToken(bodylineGrouping);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTextSimpleResponse> PDFToTextSimple([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/text-simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToTextSimpleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXLSResponse> PDFToXLS([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodylang = null, [WorkflowExpression] Func<bodyunwrapInput> bodyunwrap = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylineGrouping = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodylang, nameof(bodylang), required: false);
            SourceExpression.Validate(bodyunwrap, nameof(bodyunwrap), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodylineGrouping, nameof(bodylineGrouping), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/xls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodylang != null)
                {
                    body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                    bodypropCount++;
                }

                if (bodyunwrap != null)
                {
                    body["unwrap"] = SourceExpressionConverter.Convert(bodyunwrap);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodylineGrouping != null)
                {
                    body["lineGrouping"] = SourceExpressionConverter.ConvertToken(bodylineGrouping);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToXLSResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXLSXResponse> PDFToXLSX([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodylang = null, [WorkflowExpression] Func<bodyunwrapInput> bodyunwrap = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylineGrouping = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodylang, nameof(bodylang), required: false);
            SourceExpression.Validate(bodyunwrap, nameof(bodyunwrap), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodylineGrouping, nameof(bodylineGrouping), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/xlsx";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodylang != null)
                {
                    body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                    bodypropCount++;
                }

                if (bodyunwrap != null)
                {
                    body["unwrap"] = SourceExpressionConverter.Convert(bodyunwrap);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodylineGrouping != null)
                {
                    body["lineGrouping"] = SourceExpressionConverter.ConvertToken(bodylineGrouping);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToXLSXResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXMLResponse> PDFToXML([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodylang = null, [WorkflowExpression] Func<bodyunwrapInput> bodyunwrap = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylineGrouping = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodylang, nameof(bodylang), required: false);
            SourceExpression.Validate(bodyunwrap, nameof(bodyunwrap), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodylineGrouping, nameof(bodylineGrouping), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodylang != null)
                {
                    body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                    bodypropCount++;
                }

                if (bodyunwrap != null)
                {
                    body["unwrap"] = SourceExpressionConverter.Convert(bodyunwrap);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodylineGrouping != null)
                {
                    body["lineGrouping"] = SourceExpressionConverter.ConvertToken(bodylineGrouping);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToXMLResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJPGResponse> PDFToJPG([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/jpg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyinline != null)
                {
                    body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToJPGResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToPNGResponse> PDFToPNG([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/png";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyinline != null)
                {
                    body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToPNGResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToWEBPResponse> PDFToWEBP([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/webp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyinline != null)
                {
                    body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToWEBPResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTIFFResponse> PDFToTIFF([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyrect = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyrect, nameof(bodyrect), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/to/tiff";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyinline != null)
                {
                    body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyrect != null)
                {
                    body["rect"] = SourceExpressionConverter.ConvertToken(bodyrect);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFToTIFFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromCSVResponse> PDFFromCSV([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/from/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFFromCSVResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromDocResponse> PDFFromDoc([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/from/doc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFFromDocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromImagesResponse> PDFFromImages([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/from/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFFromImagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromEmailResponse> PDFFromEmail([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyembedAttachments = null, [WorkflowExpression] Func<bool> bodyconvertAttachments = null, [WorkflowExpression] Func<string> bodymargins = null, [WorkflowExpression] Func<string> bodypaperSize = null, [WorkflowExpression] Func<bodyorientationInput> bodyorientation = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyembedAttachments, nameof(bodyembedAttachments), required: false);
            SourceExpression.Validate(bodyconvertAttachments, nameof(bodyconvertAttachments), required: false);
            SourceExpression.Validate(bodymargins, nameof(bodymargins), required: false);
            SourceExpression.Validate(bodypaperSize, nameof(bodypaperSize), required: false);
            SourceExpression.Validate(bodyorientation, nameof(bodyorientation), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/convert/from/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyembedAttachments != null)
                {
                    body["embedAttachments"] = SourceExpressionConverter.ConvertToken(bodyembedAttachments);
                    bodypropCount++;
                }

                if (bodyconvertAttachments != null)
                {
                    body["convertAttachments"] = SourceExpressionConverter.ConvertToken(bodyconvertAttachments);
                    bodypropCount++;
                }

                if (bodymargins != null)
                {
                    body["margins"] = SourceExpressionConverter.ConvertToken(bodymargins);
                    bodypropCount++;
                }

                if (bodypaperSize != null)
                {
                    body["paperSize"] = SourceExpressionConverter.ConvertToken(bodypaperSize);
                    bodypropCount++;
                }

                if (bodyorientation != null)
                {
                    body["orientation"] = SourceExpressionConverter.Convert(bodyorientation);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFFromEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAddSecurityResponse> PDFAddSecurity([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyownerPassword, [WorkflowExpression] Func<string> bodyuserPassword = null, [WorkflowExpression] Func<bodyencryptionAlgorithmInput> bodyencryptionAlgorithm = null, [WorkflowExpression] Func<bool> bodyallowAccessibilitySupport = null, [WorkflowExpression] Func<bool> bodyallowAssemblyDocument = null, [WorkflowExpression] Func<bool> bodyallowPrintDocument = null, [WorkflowExpression] Func<bool> bodyallowFillForms = null, [WorkflowExpression] Func<bool> bodyallowModifyDocument = null, [WorkflowExpression] Func<bool> bodyallowContentExtraction = null, [WorkflowExpression] Func<bool> bodyallowModifyAnnotations = null, [WorkflowExpression] Func<bodyprintQualityInput> bodyprintQuality = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyownerPassword, nameof(bodyownerPassword), required: true);
            SourceExpression.Validate(bodyuserPassword, nameof(bodyuserPassword), required: false);
            SourceExpression.Validate(bodyencryptionAlgorithm, nameof(bodyencryptionAlgorithm), required: false);
            SourceExpression.Validate(bodyallowAccessibilitySupport, nameof(bodyallowAccessibilitySupport), required: false);
            SourceExpression.Validate(bodyallowAssemblyDocument, nameof(bodyallowAssemblyDocument), required: false);
            SourceExpression.Validate(bodyallowPrintDocument, nameof(bodyallowPrintDocument), required: false);
            SourceExpression.Validate(bodyallowFillForms, nameof(bodyallowFillForms), required: false);
            SourceExpression.Validate(bodyallowModifyDocument, nameof(bodyallowModifyDocument), required: false);
            SourceExpression.Validate(bodyallowContentExtraction, nameof(bodyallowContentExtraction), required: false);
            SourceExpression.Validate(bodyallowModifyAnnotations, nameof(bodyallowModifyAnnotations), required: false);
            SourceExpression.Validate(bodyprintQuality, nameof(bodyprintQuality), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/security/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["ownerPassword"] = SourceExpressionConverter.ConvertToken(bodyownerPassword);
                if (bodyuserPassword != null)
                {
                    body["userPassword"] = SourceExpressionConverter.ConvertToken(bodyuserPassword);
                    bodypropCount++;
                }

                if (bodyencryptionAlgorithm != null)
                {
                    body["encryptionAlgorithm"] = SourceExpressionConverter.Convert(bodyencryptionAlgorithm);
                    bodypropCount++;
                }

                if (bodyallowAccessibilitySupport != null)
                {
                    body["allowAccessibilitySupport"] = SourceExpressionConverter.ConvertToken(bodyallowAccessibilitySupport);
                    bodypropCount++;
                }

                if (bodyallowAssemblyDocument != null)
                {
                    body["allowAssemblyDocument"] = SourceExpressionConverter.ConvertToken(bodyallowAssemblyDocument);
                    bodypropCount++;
                }

                if (bodyallowPrintDocument != null)
                {
                    body["allowPrintDocument"] = SourceExpressionConverter.ConvertToken(bodyallowPrintDocument);
                    bodypropCount++;
                }

                if (bodyallowFillForms != null)
                {
                    body["allowFillForms"] = SourceExpressionConverter.ConvertToken(bodyallowFillForms);
                    bodypropCount++;
                }

                if (bodyallowModifyDocument != null)
                {
                    body["allowModifyDocument"] = SourceExpressionConverter.ConvertToken(bodyallowModifyDocument);
                    bodypropCount++;
                }

                if (bodyallowContentExtraction != null)
                {
                    body["allowContentExtraction"] = SourceExpressionConverter.ConvertToken(bodyallowContentExtraction);
                    bodypropCount++;
                }

                if (bodyallowModifyAnnotations != null)
                {
                    body["allowModifyAnnotations"] = SourceExpressionConverter.ConvertToken(bodyallowModifyAnnotations);
                    bodypropCount++;
                }

                if (bodyprintQuality != null)
                {
                    body["printQuality"] = SourceExpressionConverter.Convert(bodyprintQuality);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFAddSecurityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSecurityRemoveResponse> PDFSecurityRemove([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/security/remove";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFSecurityRemoveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromXLSXLSXResponse> PDFFromXLSXLSX([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyworksheetIndex = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/xls/convert/to/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyworksheetIndex != null)
                {
                    if (bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = SourceExpressionConverter.ConvertToken(bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFFromXLSXLSXResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoCSVResponse> XLStoCSV([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyworksheetIndex = null, [WorkflowExpression] Func<string> bodyquotationSymbol = null, [WorkflowExpression] Func<string> bodyseparatorSymbol = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            SourceExpression.Validate(bodyquotationSymbol, nameof(bodyquotationSymbol), required: false);
            SourceExpression.Validate(bodyseparatorSymbol, nameof(bodyseparatorSymbol), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/xls/convert/to/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyworksheetIndex != null)
                {
                    if (bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = SourceExpressionConverter.ConvertToken(bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (bodyquotationSymbol != null)
                {
                    body["quotationSymbol"] = SourceExpressionConverter.ConvertToken(bodyquotationSymbol);
                    bodypropCount++;
                }

                if (bodyseparatorSymbol != null)
                {
                    body["separatorSymbol"] = SourceExpressionConverter.ConvertToken(bodyseparatorSymbol);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<XLStoCSVResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoJSONResponse> XLStoJSON([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyworksheetIndex = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/xls/convert/to/json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyworksheetIndex != null)
                {
                    if (bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = SourceExpressionConverter.ConvertToken(bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<XLStoJSONResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoHTMLResponse> XLStoHTML([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyworksheetIndex = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/xls/convert/to/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyworksheetIndex != null)
                {
                    if (bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = SourceExpressionConverter.ConvertToken(bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<XLStoHTMLResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoTXTResponse> XLStoTXT([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyworksheetIndex = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/xls/convert/to/txt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyworksheetIndex != null)
                {
                    if (bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = SourceExpressionConverter.ConvertToken(bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<XLStoTXTResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoXMLResponse> XLStoXML([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyworksheetIndex = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<bool> bodyasync = null, [WorkflowExpression] Func<string> bodyprofiles = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/xls/convert/to/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyworksheetIndex != null)
                {
                    if (bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = SourceExpressionConverter.ConvertToken(bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<XLStoXMLResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFRotatePagesResponse> PDFRotatePages([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bodyangleInput> bodyangle = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyangle, nameof(bodyangle), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/edit/rotate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyangle != null)
                {
                    body["angle"] = SourceExpressionConverter.Convert(bodyangle);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFRotatePagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAutoRotatePagesResponse> PDFAutoRotatePages([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodylang = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodylang, nameof(bodylang), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/edit/rotate/auto";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodylang != null)
                {
                    if (bodylang != null)
                    {
                        body["lang"] = SourceExpressionConverter.ConvertToken(bodylang);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["lang"] = "eng";
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFAutoRotatePagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFDeletePagesResponse> PDFDeletePages([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/edit/delete-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFDeletePagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFCompressResponse> PDFCompress([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/optimize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFCompressResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFClassifierResponse> PDFClassifier([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyrulescsv = null, [WorkflowExpression] Func<string> bodyrulescsvurl = null, [WorkflowExpression] Func<bool> bodycaseSensitive = null, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyrulescsv, nameof(bodyrulescsv), required: false);
            SourceExpression.Validate(bodyrulescsvurl, nameof(bodyrulescsvurl), required: false);
            SourceExpression.Validate(bodycaseSensitive, nameof(bodycaseSensitive), required: false);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/classifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyrulescsv != null)
                {
                    body["rulescsv"] = SourceExpressionConverter.ConvertToken(bodyrulescsv);
                    bodypropCount++;
                }

                if (bodyrulescsvurl != null)
                {
                    body["rulescsvurl"] = SourceExpressionConverter.ConvertToken(bodyrulescsvurl);
                    bodypropCount++;
                }

                if (bodycaseSensitive != null)
                {
                    if (bodycaseSensitive != null)
                    {
                        body["caseSensitive"] = SourceExpressionConverter.ConvertToken(bodycaseSensitive);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["caseSensitive"] = true;
                    bodypropCount++;
                }

                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFClassifierResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailSendResponse> EmailSend([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodysmtpserver, [WorkflowExpression] Func<string> bodysmtpport, [WorkflowExpression] Func<string> bodysmtpusername, [WorkflowExpression] Func<string> bodysmtppassword, [WorkflowExpression] Func<string> bodybodytext = null, [WorkflowExpression] Func<string> bodybodyhtml = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            SourceExpression.Validate(bodysmtpserver, nameof(bodysmtpserver), required: true);
            SourceExpression.Validate(bodysmtpport, nameof(bodysmtpport), required: true);
            SourceExpression.Validate(bodysmtpusername, nameof(bodysmtpusername), required: true);
            SourceExpression.Validate(bodysmtppassword, nameof(bodysmtppassword), required: true);
            SourceExpression.Validate(bodybodytext, nameof(bodybodytext), required: false);
            SourceExpression.Validate(bodybodyhtml, nameof(bodybodyhtml), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/email/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                if (bodybodytext != null)
                {
                    body["bodytext"] = SourceExpressionConverter.ConvertToken(bodybodytext);
                    bodypropCount++;
                }

                if (bodybodyhtml != null)
                {
                    body["bodyhtml"] = SourceExpressionConverter.ConvertToken(bodybodyhtml);
                    bodypropCount++;
                }

                bodypropCount++;
                body["smtpserver"] = SourceExpressionConverter.ConvertToken(bodysmtpserver);
                bodypropCount++;
                body["smtpport"] = SourceExpressionConverter.ConvertToken(bodysmtpport);
                bodypropCount++;
                body["smtpusername"] = SourceExpressionConverter.ConvertToken(bodysmtpusername);
                bodypropCount++;
                body["smtppassword"] = SourceExpressionConverter.ConvertToken(bodysmtppassword);
                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmailSendResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailDecodeResponse> EmailDecode([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/email/decode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmailDecodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailAttachmentExtractionResponse> EmailAttachmentExtraction([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/email/extract-attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmailAttachmentExtractionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAttachmentExtractionResponse> PDFAttachmentExtraction([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyinline = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyprofiles = null, [WorkflowExpression] Func<bool> bodyasync = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyinline, nameof(bodyinline), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            SourceExpression.Validate(bodyasync, nameof(bodyasync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pdf/attachments/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyinline != null)
                {
                    if (bodyinline != null)
                    {
                        body["inline"] = SourceExpressionConverter.ConvertToken(bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    if (bodyexpiration != null)
                    {
                        body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodyasync != null)
                {
                    if (bodyasync != null)
                    {
                        body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFAttachmentExtractionResponse>(BuildSourceInput);
        }
    }

    public class PdfcoTriggers([ConnectionName] string connectionId)
    {
    }

    public class HtmlToPdfResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public enum bodypaperSizeInput
    {
        Letter,
        Legal,
        Tabloid,
        Ledger,
        A0,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6
    }

    public enum bodyorientationInput
    {
        [EnumMember(Value = "")]
        None,
        Portait,
        Landscape
    }

    public class UrlToPdfResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class PdfFillerResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class MergePdfSimplifiedResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class MergePdfResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class SplitPdfResponse
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class SplitPdf2Response
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class PDFSerarchTextResponse
    {
        [JsonProperty("body")]
        public PDFSerarchTextResponseBodyTypeItem[] Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFSerarchTextResponseBodyTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("left")]
        public double Left { get; set; }

        [JsonProperty("top")]
        public double Top { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }
    }

    public enum bodywordMatchingModeInput
    {
        [EnumMember(Value = "")]
        None,
        SmartMatch,
        ExactMatch,
        [EnumMember(Value = "None")]
        None2
    }

    public class DocumentParserResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public DocumentParserResponseBodyType Body { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class DocumentParserResponseBodyType
    {
        [JsonProperty("objects")]
        public DocumentParserResponseBodyTypeObjectsTypeItem[] Objects { get; set; }
    }

    public class DocumentParserResponseBodyTypeObjectsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("rectangle")]
        public double[] Rectangle { get; set; }

        [JsonProperty("rows")]
        public JToken[] Rows { get; set; }
    }

    public enum bodyoutputFormatInput
    {
        JSON,
        CSV,
        XML
    }

    public class JobCheckResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("jobDuration")]
        public int JobDuration { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("errorCode")]
        public int ErrorCode { get; set; }
    }

    public class BarcodeGeneratorResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public enum bodytypeInput
    {
        Code128,
        Code39,
        Postnet,
        UPCA,
        EAN8,
        ISBN,
        Codabar,
        I2of5,
        Code93,
        EAN13,
        JAN13,
        Bookland,
        UPCE,
        PDF417,
        PDF417Truncated,
        DataMatrix,
        QRCode,
        Aztec,
        Planet,
        EAN128,
        [EnumMember(Value = "GS1_128")]
        GS1128,
        USPSSackLabel,
        USPSTrayLabel,
        DeutschePostIdentcode,
        DeutschePostLeitcode,
        Numly,
        PZN,
        OpticalProduct,
        SwissPostParcel,
        RoyalMail,
        DutchKix,
        SingaporePostalCode,
        EAN2,
        EAN5,
        EAN14,
        MacroPDF417,
        MicroPDF417,
        [EnumMember(Value = "GS1_DataMatrix")]
        GS1DataMatrix,
        Telepen,
        IntelligentMail,
        [EnumMember(Value = "GS1_DataBar_Omnidirectional")]
        GS1DataBarOmnidirectional,
        [EnumMember(Value = "GS1_DataBar_Truncated")]
        GS1DataBarTruncated,
        [EnumMember(Value = "GS1_DataBar_Stacked")]
        GS1DataBarStacked,
        [EnumMember(Value = "GS1_DataBar_Stacked_Omnidirectional")]
        GS1DataBarStackedOmnidirectional,
        [EnumMember(Value = "GS1_DataBar_Limited")]
        GS1DataBarLimited,
        [EnumMember(Value = "GS1_DataBar_Expanded")]
        GS1DataBarExpanded,
        [EnumMember(Value = "GS1_DataBar_Expanded_Stacked")]
        GS1DataBarExpandedStacked,
        MaxiCode,
        Plessey,
        MSI,
        ITF14,
        GTIN12,
        GTIN8,
        GTIN13,
        GTIN14,
        [EnumMember(Value = "GS1_QRCode")]
        GS1QRCode,
        PharmaCode
    }

    public class BarcodeReaderResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("barcodes")]
        public BarcodeReaderResponseBarcodesTypeItem[] Barcodes { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class BarcodeReaderResponseBarcodesTypeItem
    {
        public string Value { get; set; }
        public int Type { get; set; }
        public string Rect { get; set; }
        public int Page { get; set; }
        public string File { get; set; }
        public double Confidence { get; set; }
        public string Metadata { get; set; }
        public string TypeName { get; set; }
    }

    public class PDFInfoReaderResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("info")]
        public PDFInfoReaderResponseInfoType Info { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFInfoReaderResponseInfoType
    {
        public int PageCount { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Subject { get; set; }
        public string CreationDate { get; set; }
        public string Bookmarks { get; set; }
        public string Keywords { get; set; }
        public string Creator { get; set; }
        public bool Encrypted { get; set; }
        public bool PasswordProtected { get; set; }
        public PDFInfoReaderResponseInfoTypePageRectangleType PageRectangle { get; set; }
        public string ModificationDate { get; set; }
        public int AttachmentCount { get; set; }
        public string EncryptionAlgorithm { get; set; }
        public bool PermissionPrinting { get; set; }
        public bool PermissionModifyDocument { get; set; }
        public bool PermissionContentExtraction { get; set; }
        public bool PermissionModifyAnnotations { get; set; }
        public bool PermissionFillForms { get; set; }
        public bool PermissionAccessibility { get; set; }
        public bool PermissionAssemble { get; set; }
        public bool PermissionHighQualityPrint { get; set; }
    }

    public class PDFInfoReaderResponseInfoTypePageRectangleType
    {
        public PDFInfoReaderResponseInfoTypePageRectangleTypeLocationType Location { get; set; }
        public string Size { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Left { get; set; }
        public double Top { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }
        public bool IsEmpty { get; set; }
    }

    public class PDFInfoReaderResponseInfoTypePageRectangleTypeLocationType
    {
        public bool IsEmpty { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class PDFFormsInfoReaderResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("info")]
        public PDFFormsInfoReaderResponseInfoType Info { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoType
    {
        public int PageCount { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Subject { get; set; }
        public string CreationDate { get; set; }
        public string Bookmarks { get; set; }
        public string Keywords { get; set; }
        public string Creator { get; set; }
        public bool Encrypted { get; set; }
        public bool PasswordProtected { get; set; }
        public PDFFormsInfoReaderResponseInfoTypePageRectangleType PageRectangle { get; set; }
        public string ModificationDate { get; set; }
        public int AttachmentCount { get; set; }
        public string EncryptionAlgorithm { get; set; }
        public bool PermissionPrinting { get; set; }
        public bool PermissionModifyDocument { get; set; }
        public bool PermissionContentExtraction { get; set; }
        public bool PermissionModifyAnnotations { get; set; }
        public bool PermissionFillForms { get; set; }
        public bool PermissionAccessibility { get; set; }
        public bool PermissionAssemble { get; set; }
        public bool PermissionHighQualityPrint { get; set; }
        public PDFFormsInfoReaderResponseInfoTypeCustomPropertiesTypeItem[] CustomProperties { get; set; }
        public PDFFormsInfoReaderResponseInfoTypeFieldsInfoType FieldsInfo { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoTypePageRectangleType
    {
        public PDFFormsInfoReaderResponseInfoTypePageRectangleTypeLocationType Location { get; set; }
        public string Size { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Left { get; set; }
        public double Top { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }
        public bool IsEmpty { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoTypePageRectangleTypeLocationType
    {
        public bool IsEmpty { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoTypeCustomPropertiesTypeItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoTypeFieldsInfoType
    {
        public PDFFormsInfoReaderResponseInfoTypeFieldsInfoTypeFieldsTypeItem[] Fields { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoTypeFieldsInfoTypeFieldsTypeItem
    {
        public int PageIndex { get; set; }
        public string Type { get; set; }
        public string FieldName { get; set; }
        public string AltFieldName { get; set; }
        public string Value { get; set; }
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class PDFFindTableResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public PDFFindTableResponseBodyType Body { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFindTableResponseBodyType
    {
        [JsonProperty("tables")]
        public PDFFindTableResponseBodyTypeTablesTypeItem[] Tables { get; set; }
    }

    public class PDFFindTableResponseBodyTypeTablesTypeItem
    {
        public int PageIndex { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double[] Columns { get; set; }

        [JsonProperty("rect")]
        public string Rect { get; set; }
    }

    public class SearchAndReplaceResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class SearchAndReplaceWithImageResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class SearchAndDeleteTextResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFSearchableResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFUnSearchableResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToCSVResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public enum bodyunwrapInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class PDFToJSONResponse
    {
        [JsonProperty("body")]
        public JToken Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToJSONMetaResponse
    {
        [JsonProperty("body")]
        public JToken Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToTextResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToTextSimpleResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToXLSResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToXLSXResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToXMLResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToJPGResponse
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToPNGResponse
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToWEBPResponse
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToTIFFResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromCSVResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromDocResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromImagesResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromEmailResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFAddSecurityResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public enum bodyencryptionAlgorithmInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "RC4_40bit")]
        RC440bit,
        [EnumMember(Value = "RC4_128bit")]
        RC4128bit,
        [EnumMember(Value = "AES_128bit")]
        AES128bit,
        [EnumMember(Value = "AES_256bit")]
        AES256bit
    }

    public enum bodyprintQualityInput
    {
        [EnumMember(Value = "")]
        None,
        HighResolution,
        LowResolution
    }

    public class PDFSecurityRemoveResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromXLSXLSXResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class XLStoCSVResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class XLStoJSONResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class XLStoHTMLResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class XLStoTXTResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class XLStoXMLResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFRotatePagesResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public enum bodyangleInput
    {
        _90 = 90,
        _180 = 180,
        _270 = 270
    }

    public class PDFAutoRotatePagesResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFDeletePagesResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFCompressResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFClassifierResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public PDFClassifierResponseBodyType Body { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFClassifierResponseBodyType
    {
        [JsonProperty("classes")]
        public PDFClassifierResponseBodyTypeClassesTypeItem[] Classes { get; set; }
    }

    public class PDFClassifierResponseBodyTypeClassesTypeItem
    {
        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class EmailSendResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class EmailDecodeResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public EmailDecodeResponseBodyType Body { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class EmailDecodeResponseBodyType
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("to")]
        public EmailDecodeResponseBodyTypeToTypeItem[] To { get; set; }

        [JsonProperty("cc")]
        public EmailDecodeResponseBodyTypeCcTypeItem[] Cc { get; set; }

        [JsonProperty("bcc")]
        public EmailDecodeResponseBodyTypeBccTypeItem[] Bcc { get; set; }

        [JsonProperty("sentAt")]
        public string SentAt { get; set; }

        [JsonProperty("receivedAt")]
        public string ReceivedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("bodyHtml")]
        public string BodyHtml { get; set; }

        [JsonProperty("bodyText")]
        public string BodyText { get; set; }

        [JsonProperty("attachmentCount")]
        public int AttachmentCount { get; set; }
    }

    public class EmailDecodeResponseBodyTypeToTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class EmailDecodeResponseBodyTypeCcTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class EmailDecodeResponseBodyTypeBccTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class EmailAttachmentExtractionResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public EmailAttachmentExtractionResponseBodyType Body { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class EmailAttachmentExtractionResponseBodyType
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("bodyHtml")]
        public string BodyHtml { get; set; }

        [JsonProperty("bodyText")]
        public string BodyText { get; set; }

        [JsonProperty("attachments")]
        public EmailAttachmentExtractionResponseBodyTypeAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class EmailAttachmentExtractionResponseBodyTypeAttachmentsTypeItem
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("contentid")]
        public string Contentid { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("filesizeinbytes")]
        public int Filesizeinbytes { get; set; }
    }

    public class PDFAttachmentExtractionResponse
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco;

    public partial class WorkflowManagedActions
    {
        public PdfcoActions Pdfco(string connectionId) => new PdfcoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PdfcoTriggers Pdfco(string connectionId) => new PdfcoTriggers(connectionId);
    }
}