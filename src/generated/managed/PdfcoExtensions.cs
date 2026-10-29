//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfcoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<HtmlToPdfResponse, ApiConnectionActionConfiguration> HtmlToPdf(Expression<Func<string>> bodyhtml, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymargins = null, Expression<Func<bodypaperSizeInput>> bodypaperSize = null, Expression<Func<bodyorientationInput>> bodyorientation = null, Expression<Func<bool>> bodyprintBackground = null, Expression<Func<string>> bodyheader = null, Expression<Func<string>> bodyfooter = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyhtml = WorkflowExpression.Compile(bodyhtml, nameof(bodyhtml), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodymargins = WorkflowExpression.Compile(bodymargins, nameof(bodymargins), required: false);
            var __workflow_bodypaperSize = WorkflowExpression.Compile(bodypaperSize, nameof(bodypaperSize), required: false);
            var __workflow_bodyorientation = WorkflowExpression.Compile(bodyorientation, nameof(bodyorientation), required: false);
            var __workflow_bodyprintBackground = WorkflowExpression.Compile(bodyprintBackground, nameof(bodyprintBackground), required: false);
            var __workflow_bodyheader = WorkflowExpression.Compile(bodyheader, nameof(bodyheader), required: false);
            var __workflow_bodyfooter = WorkflowExpression.Compile(bodyfooter, nameof(bodyfooter), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<HtmlToPdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["html"] = ExpressionConverter.ConvertO(__workflow_bodyhtml);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodymargins != null)
                {
                    if (__workflow_bodymargins != null)
                    {
                        body["margins"] = ExpressionConverter.ConvertO(__workflow_bodymargins);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["margins"] = "5px 5px 5px 5px";
                    bodypropCount++;
                }

                if (__workflow_bodypaperSize != null)
                {
                    if (__workflow_bodypaperSize != null)
                    {
                        body["paperSize"] = ExpressionConverter.ConvertO(__workflow_bodypaperSize);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["paperSize"] = "Letter";
                    bodypropCount++;
                }

                if (__workflow_bodyorientation != null)
                {
                    if (__workflow_bodyorientation != null)
                    {
                        body["orientation"] = ExpressionConverter.ConvertO(__workflow_bodyorientation);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["orientation"] = "portrait";
                    bodypropCount++;
                }

                if (__workflow_bodyprintBackground != null)
                {
                    if (__workflow_bodyprintBackground != null)
                    {
                        body["printBackground"] = ExpressionConverter.ConvertO(__workflow_bodyprintBackground);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["printBackground"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyheader != null)
                {
                    body["header"] = ExpressionConverter.ConvertO(__workflow_bodyheader);
                    bodypropCount++;
                }

                if (__workflow_bodyfooter != null)
                {
                    body["footer"] = ExpressionConverter.ConvertO(__workflow_bodyfooter);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<HtmlToPdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<UrlToPdfResponse, ApiConnectionActionConfiguration> UrlToPdf(Expression<Func<string>> bodyurl, Expression<Func<string>> bodymargins = null, Expression<Func<string>> bodypaperSize = null, Expression<Func<bodyorientationInput>> bodyorientation = null, Expression<Func<bool>> bodyprintBackground = null, Expression<Func<string>> bodyheader = null, Expression<Func<string>> bodyfooter = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodymargins = WorkflowExpression.Compile(bodymargins, nameof(bodymargins), required: false);
            var __workflow_bodypaperSize = WorkflowExpression.Compile(bodypaperSize, nameof(bodypaperSize), required: false);
            var __workflow_bodyorientation = WorkflowExpression.Compile(bodyorientation, nameof(bodyorientation), required: false);
            var __workflow_bodyprintBackground = WorkflowExpression.Compile(bodyprintBackground, nameof(bodyprintBackground), required: false);
            var __workflow_bodyheader = WorkflowExpression.Compile(bodyheader, nameof(bodyheader), required: false);
            var __workflow_bodyfooter = WorkflowExpression.Compile(bodyfooter, nameof(bodyfooter), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<UrlToPdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodymargins != null)
                {
                    if (__workflow_bodymargins != null)
                    {
                        body["margins"] = ExpressionConverter.ConvertO(__workflow_bodymargins);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["margins"] = "5mm";
                    bodypropCount++;
                }

                if (__workflow_bodypaperSize != null)
                {
                    if (__workflow_bodypaperSize != null)
                    {
                        body["paperSize"] = ExpressionConverter.ConvertO(__workflow_bodypaperSize);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["paperSize"] = "Letter";
                    bodypropCount++;
                }

                if (__workflow_bodyorientation != null)
                {
                    if (__workflow_bodyorientation != null)
                    {
                        body["orientation"] = ExpressionConverter.ConvertO(__workflow_bodyorientation);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["orientation"] = "Portrait";
                    bodypropCount++;
                }

                if (__workflow_bodyprintBackground != null)
                {
                    if (__workflow_bodyprintBackground != null)
                    {
                        body["printBackground"] = ExpressionConverter.ConvertO(__workflow_bodyprintBackground);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["printBackground"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyheader != null)
                {
                    body["header"] = ExpressionConverter.ConvertO(__workflow_bodyheader);
                    bodypropCount++;
                }

                if (__workflow_bodyfooter != null)
                {
                    body["footer"] = ExpressionConverter.ConvertO(__workflow_bodyfooter);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<UrlToPdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PdfFillerResponse, ApiConnectionActionConfiguration> PdfFiller(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyannotationsString = null, Expression<Func<string>> bodyimagesString = null, Expression<Func<string>> bodyfieldsString = null, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodyinline = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyannotationsString = WorkflowExpression.Compile(bodyannotationsString, nameof(bodyannotationsString), required: false);
            var __workflow_bodyimagesString = WorkflowExpression.Compile(bodyimagesString, nameof(bodyimagesString), required: false);
            var __workflow_bodyfieldsString = WorkflowExpression.Compile(bodyfieldsString, nameof(bodyfieldsString), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<PdfFillerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyannotationsString != null)
                {
                    body["annotationsString"] = ExpressionConverter.ConvertO(__workflow_bodyannotationsString);
                    bodypropCount++;
                }

                if (__workflow_bodyimagesString != null)
                {
                    body["imagesString"] = ExpressionConverter.ConvertO(__workflow_bodyimagesString);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldsString != null)
                {
                    body["fieldsString"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsString);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<PdfFillerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<MergePdfSimplifiedResponse, ApiConnectionActionConfiguration> MergePdfSimplified(Expression<Func<string>> bodyurl, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<MergePdfSimplifiedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<MergePdfSimplifiedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<MergePdfResponse, ApiConnectionActionConfiguration> MergePdf(Expression<Func<string>> bodyurl, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<MergePdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/merge2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<MergePdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SplitPdfResponse, ApiConnectionActionConfiguration> SplitPdf(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: true);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<SplitPdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<SplitPdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SplitPdf2Response, ApiConnectionActionConfiguration> SplitPdf2(Expression<Func<string>> bodyurl, Expression<Func<string>> bodysearchString, Expression<Func<bool>> bodyexcludeKeyPages = null, Expression<Func<bool>> bodyregexSearch = null, Expression<Func<bool>> bodycaseSensitive = null, Expression<Func<string>> bodylang = null, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodysearchString = WorkflowExpression.Compile(bodysearchString, nameof(bodysearchString), required: true);
            var __workflow_bodyexcludeKeyPages = WorkflowExpression.Compile(bodyexcludeKeyPages, nameof(bodyexcludeKeyPages), required: false);
            var __workflow_bodyregexSearch = WorkflowExpression.Compile(bodyregexSearch, nameof(bodyregexSearch), required: false);
            var __workflow_bodycaseSensitive = WorkflowExpression.Compile(bodycaseSensitive, nameof(bodycaseSensitive), required: false);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<SplitPdf2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/split2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["searchString"] = ExpressionConverter.ConvertO(__workflow_bodysearchString);
                if (__workflow_bodyexcludeKeyPages != null)
                {
                    if (__workflow_bodyexcludeKeyPages != null)
                    {
                        body["excludeKeyPages"] = ExpressionConverter.ConvertO(__workflow_bodyexcludeKeyPages);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["excludeKeyPages"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyregexSearch != null)
                {
                    if (__workflow_bodyregexSearch != null)
                    {
                        body["regexSearch"] = ExpressionConverter.ConvertO(__workflow_bodyregexSearch);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["regexSearch"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodycaseSensitive != null)
                {
                    if (__workflow_bodycaseSensitive != null)
                    {
                        body["caseSensitive"] = ExpressionConverter.ConvertO(__workflow_bodycaseSensitive);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["caseSensitive"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodylang != null)
                {
                    if (__workflow_bodylang != null)
                    {
                        body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["lang"] = "eng";
                    bodypropCount++;
                }

                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<SplitPdf2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSerarchTextResponse, ApiConnectionActionConfiguration> PDFSerarchText(Expression<Func<string>> bodyurl, Expression<Func<string>> bodysearchString, Expression<Func<bool>> bodyregexSearch = null, Expression<Func<string>> bodypages = null, Expression<Func<bool>> bodyinline = null, Expression<Func<bodywordMatchingModeInput>> bodywordMatchingMode = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodysearchString = WorkflowExpression.Compile(bodysearchString, nameof(bodysearchString), required: true);
            var __workflow_bodyregexSearch = WorkflowExpression.Compile(bodyregexSearch, nameof(bodyregexSearch), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodywordMatchingMode = WorkflowExpression.Compile(bodywordMatchingMode, nameof(bodywordMatchingMode), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFSerarchTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["searchString"] = ExpressionConverter.ConvertO(__workflow_bodysearchString);
                if (__workflow_bodyregexSearch != null)
                {
                    if (__workflow_bodyregexSearch != null)
                    {
                        body["regexSearch"] = ExpressionConverter.ConvertO(__workflow_bodyregexSearch);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["regexSearch"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodywordMatchingMode != null)
                {
                    body["wordMatchingMode"] = ExpressionConverter.ConvertO(__workflow_bodywordMatchingMode);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFSerarchTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<DocumentParserResponse, ApiConnectionActionConfiguration> DocumentParser(Expression<Func<string>> bodyurl, Expression<Func<bodyoutputFormatInput>> bodyoutputFormat, Expression<Func<string>> bodytemplateId = null, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyoutputFormat = WorkflowExpression.Compile(bodyoutputFormat, nameof(bodyoutputFormat), required: true);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<DocumentParserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/documentparser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodytemplateId != null)
                {
                    body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["outputFormat"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFormat);
                if (__workflow_bodyinline != null)
                {
                    body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DocumentParserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<JobCheckResponse, ApiConnectionActionConfiguration> JobCheck(Expression<Func<string>> bodyjobid)
        {
            var __workflow_bodyjobid = WorkflowExpression.Compile(bodyjobid, nameof(bodyjobid), required: true);
            return new DeferredBodyAction<JobCheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/job/check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["jobid"] = ExpressionConverter.ConvertO(__workflow_bodyjobid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JobCheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<BarcodeGeneratorResponse, ApiConnectionActionConfiguration> BarcodeGenerator(Expression<Func<string>> bodyvalue, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydecorationImage = null, Expression<Func<bool>> bodyasync = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydecorationImage = WorkflowExpression.Compile(bodydecorationImage, nameof(bodydecorationImage), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<BarcodeGeneratorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/barcode/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodydecorationImage != null)
                {
                    body["decorationImage"] = ExpressionConverter.ConvertO(__workflow_bodydecorationImage);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BarcodeGeneratorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<BarcodeReaderResponse, ApiConnectionActionConfiguration> BarcodeReader(Expression<Func<string>> bodyurl, Expression<Func<string>> bodytypes, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodytypes = WorkflowExpression.Compile(bodytypes, nameof(bodytypes), required: true);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<BarcodeReaderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/barcode/read/from/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["types"] = ExpressionConverter.ConvertO(__workflow_bodytypes);
                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<BarcodeReaderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFInfoReaderResponse, ApiConnectionActionConfiguration> PDFInfoReader(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFInfoReaderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/info";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFInfoReaderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFormsInfoReaderResponse, ApiConnectionActionConfiguration> PDFFormsInfoReader(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFFormsInfoReaderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/info/fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFFormsInfoReaderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFindTableResponse, ApiConnectionActionConfiguration> PDFFindTable(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages = null, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<PDFFindTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/find/table";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<PDFFindTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndReplaceResponse, ApiConnectionActionConfiguration> SearchAndReplace(Expression<Func<string>> bodyurl, Expression<Func<string[]>> bodysearchStrings, Expression<Func<string[]>> bodyreplaceStrings = null, Expression<Func<bool>> bodycaseSensitive = null, Expression<Func<int>> bodyreplacementLimit = null, Expression<Func<bool>> bodyregex = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodysearchStrings = WorkflowExpression.Compile(bodysearchStrings, nameof(bodysearchStrings), required: true);
            var __workflow_bodyreplaceStrings = WorkflowExpression.Compile(bodyreplaceStrings, nameof(bodyreplaceStrings), required: false);
            var __workflow_bodycaseSensitive = WorkflowExpression.Compile(bodycaseSensitive, nameof(bodycaseSensitive), required: false);
            var __workflow_bodyreplacementLimit = WorkflowExpression.Compile(bodyreplacementLimit, nameof(bodyreplacementLimit), required: false);
            var __workflow_bodyregex = WorkflowExpression.Compile(bodyregex, nameof(bodyregex), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<SearchAndReplaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/replace-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["searchStrings"] = ExpressionConverter.ConvertO(__workflow_bodysearchStrings);
                if (__workflow_bodyreplaceStrings != null)
                {
                    body["replaceStrings"] = ExpressionConverter.ConvertO(__workflow_bodyreplaceStrings);
                    bodypropCount++;
                }

                if (__workflow_bodycaseSensitive != null)
                {
                    body["caseSensitive"] = ExpressionConverter.ConvertO(__workflow_bodycaseSensitive);
                    bodypropCount++;
                }

                if (__workflow_bodyreplacementLimit != null)
                {
                    body["replacementLimit"] = ExpressionConverter.ConvertO(__workflow_bodyreplacementLimit);
                    bodypropCount++;
                }

                if (__workflow_bodyregex != null)
                {
                    body["regex"] = ExpressionConverter.ConvertO(__workflow_bodyregex);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<SearchAndReplaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndReplaceWithImageResponse, ApiConnectionActionConfiguration> SearchAndReplaceWithImage(Expression<Func<string>> bodyurl, Expression<Func<string>> bodysearchString, Expression<Func<string>> bodyreplaceImage, Expression<Func<bool>> bodycaseSensitive = null, Expression<Func<string>> bodypages = null, Expression<Func<bool>> bodyasync = null, Expression<Func<bool>> bodyregex = null, Expression<Func<int>> bodyreplacementLimit = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodypassword = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodysearchString = WorkflowExpression.Compile(bodysearchString, nameof(bodysearchString), required: true);
            var __workflow_bodyreplaceImage = WorkflowExpression.Compile(bodyreplaceImage, nameof(bodyreplaceImage), required: true);
            var __workflow_bodycaseSensitive = WorkflowExpression.Compile(bodycaseSensitive, nameof(bodycaseSensitive), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyregex = WorkflowExpression.Compile(bodyregex, nameof(bodyregex), required: false);
            var __workflow_bodyreplacementLimit = WorkflowExpression.Compile(bodyreplacementLimit, nameof(bodyreplacementLimit), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<SearchAndReplaceWithImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/replace-text-with-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodycaseSensitive != null)
                {
                    if (__workflow_bodycaseSensitive != null)
                    {
                        body["caseSensitive"] = ExpressionConverter.ConvertO(__workflow_bodycaseSensitive);
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
                body["searchString"] = ExpressionConverter.ConvertO(__workflow_bodysearchString);
                bodypropCount++;
                body["replaceImage"] = ExpressionConverter.ConvertO(__workflow_bodyreplaceImage);
                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyregex != null)
                {
                    if (__workflow_bodyregex != null)
                    {
                        body["regex"] = ExpressionConverter.ConvertO(__workflow_bodyregex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["regex"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyreplacementLimit != null)
                {
                    if (__workflow_bodyreplacementLimit != null)
                    {
                        body["replacementLimit"] = ExpressionConverter.ConvertO(__workflow_bodyreplacementLimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["replacementLimit"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchAndReplaceWithImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndDeleteTextResponse, ApiConnectionActionConfiguration> SearchAndDeleteText(Expression<Func<string>> bodyurl, Expression<Func<string[]>> bodysearchStrings, Expression<Func<bool>> bodycaseSensitive = null, Expression<Func<bool>> bodyregex = null, Expression<Func<int>> bodyreplacementLimit = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodysearchStrings = WorkflowExpression.Compile(bodysearchStrings, nameof(bodysearchStrings), required: true);
            var __workflow_bodycaseSensitive = WorkflowExpression.Compile(bodycaseSensitive, nameof(bodycaseSensitive), required: false);
            var __workflow_bodyregex = WorkflowExpression.Compile(bodyregex, nameof(bodyregex), required: false);
            var __workflow_bodyreplacementLimit = WorkflowExpression.Compile(bodyreplacementLimit, nameof(bodyreplacementLimit), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<SearchAndDeleteTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/delete-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["searchStrings"] = ExpressionConverter.ConvertO(__workflow_bodysearchStrings);
                if (__workflow_bodycaseSensitive != null)
                {
                    if (__workflow_bodycaseSensitive != null)
                    {
                        body["caseSensitive"] = ExpressionConverter.ConvertO(__workflow_bodycaseSensitive);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["caseSensitive"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyregex != null)
                {
                    body["regex"] = ExpressionConverter.ConvertO(__workflow_bodyregex);
                    bodypropCount++;
                }

                if (__workflow_bodyreplacementLimit != null)
                {
                    if (__workflow_bodyreplacementLimit != null)
                    {
                        body["replacementLimit"] = ExpressionConverter.ConvertO(__workflow_bodyreplacementLimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["replacementLimit"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<SearchAndDeleteTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSearchableResponse, ApiConnectionActionConfiguration> PDFSearchable(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFSearchableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/makesearchable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodylang != null)
                {
                    if (__workflow_bodylang != null)
                    {
                        body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["lang"] = "eng";
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFSearchableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFUnSearchableResponse, ApiConnectionActionConfiguration> PDFUnSearchable(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFUnSearchableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/makeunsearchable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFUnSearchableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToCSVResponse, ApiConnectionActionConfiguration> PDFToCSV(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bool>> bodyinline = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodyunwrap = WorkflowExpression.Compile(bodyunwrap, nameof(bodyunwrap), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodylineGrouping = WorkflowExpression.Compile(bodylineGrouping, nameof(bodylineGrouping), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToCSVResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
                    bodypropCount++;
                }

                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyunwrap != null)
                {
                    body["unwrap"] = ExpressionConverter.ConvertO(__workflow_bodyunwrap);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodylineGrouping != null)
                {
                    body["lineGrouping"] = ExpressionConverter.ConvertO(__workflow_bodylineGrouping);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToCSVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJSONResponse, ApiConnectionActionConfiguration> PDFToJSON(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bool>> bodyinline = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodyunwrap = WorkflowExpression.Compile(bodyunwrap, nameof(bodyunwrap), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodylineGrouping = WorkflowExpression.Compile(bodylineGrouping, nameof(bodylineGrouping), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToJSONResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/json2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
                    bodypropCount++;
                }

                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyunwrap != null)
                {
                    body["unwrap"] = ExpressionConverter.ConvertO(__workflow_bodyunwrap);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodylineGrouping != null)
                {
                    body["lineGrouping"] = ExpressionConverter.ConvertO(__workflow_bodylineGrouping);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToJSONResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJSONMetaResponse, ApiConnectionActionConfiguration> PDFToJSONMeta(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bool>> bodyinline = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodyunwrap = WorkflowExpression.Compile(bodyunwrap, nameof(bodyunwrap), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodylineGrouping = WorkflowExpression.Compile(bodylineGrouping, nameof(bodylineGrouping), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToJSONMetaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/json-meta";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
                    bodypropCount++;
                }

                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyunwrap != null)
                {
                    body["unwrap"] = ExpressionConverter.ConvertO(__workflow_bodyunwrap);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodylineGrouping != null)
                {
                    body["lineGrouping"] = ExpressionConverter.ConvertO(__workflow_bodylineGrouping);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToJSONMetaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTextResponse, ApiConnectionActionConfiguration> PDFToText(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bool>> bodyinline = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodyunwrap = WorkflowExpression.Compile(bodyunwrap, nameof(bodyunwrap), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodylineGrouping = WorkflowExpression.Compile(bodylineGrouping, nameof(bodylineGrouping), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
                    bodypropCount++;
                }

                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyunwrap != null)
                {
                    body["unwrap"] = ExpressionConverter.ConvertO(__workflow_bodyunwrap);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodylineGrouping != null)
                {
                    body["lineGrouping"] = ExpressionConverter.ConvertO(__workflow_bodylineGrouping);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTextSimpleResponse, ApiConnectionActionConfiguration> PDFToTextSimple(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypages = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            return new DeferredBodyAction<PDFToTextSimpleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/text-simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
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

                return new ApiConnectionAction<PDFToTextSimpleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXLSResponse, ApiConnectionActionConfiguration> PDFToXLS(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            var __workflow_bodyunwrap = WorkflowExpression.Compile(bodyunwrap, nameof(bodyunwrap), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodylineGrouping = WorkflowExpression.Compile(bodylineGrouping, nameof(bodylineGrouping), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToXLSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/xls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
                    bodypropCount++;
                }

                if (__workflow_bodyunwrap != null)
                {
                    body["unwrap"] = ExpressionConverter.ConvertO(__workflow_bodyunwrap);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodylineGrouping != null)
                {
                    body["lineGrouping"] = ExpressionConverter.ConvertO(__workflow_bodylineGrouping);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToXLSResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXLSXResponse, ApiConnectionActionConfiguration> PDFToXLSX(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            var __workflow_bodyunwrap = WorkflowExpression.Compile(bodyunwrap, nameof(bodyunwrap), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodylineGrouping = WorkflowExpression.Compile(bodylineGrouping, nameof(bodylineGrouping), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToXLSXResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/xlsx";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
                    bodypropCount++;
                }

                if (__workflow_bodyunwrap != null)
                {
                    body["unwrap"] = ExpressionConverter.ConvertO(__workflow_bodyunwrap);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodylineGrouping != null)
                {
                    body["lineGrouping"] = ExpressionConverter.ConvertO(__workflow_bodylineGrouping);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToXLSXResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXMLResponse, ApiConnectionActionConfiguration> PDFToXML(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodylang = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            var __workflow_bodyunwrap = WorkflowExpression.Compile(bodyunwrap, nameof(bodyunwrap), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodylineGrouping = WorkflowExpression.Compile(bodylineGrouping, nameof(bodylineGrouping), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToXMLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodylang != null)
                {
                    body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
                    bodypropCount++;
                }

                if (__workflow_bodyunwrap != null)
                {
                    body["unwrap"] = ExpressionConverter.ConvertO(__workflow_bodyunwrap);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["async"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodylineGrouping != null)
                {
                    body["lineGrouping"] = ExpressionConverter.ConvertO(__workflow_bodylineGrouping);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToXMLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJPGResponse, ApiConnectionActionConfiguration> PDFToJPG(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToJPGResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/jpg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyinline != null)
                {
                    body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToJPGResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToPNGResponse, ApiConnectionActionConfiguration> PDFToPNG(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToPNGResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/png";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyinline != null)
                {
                    body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToPNGResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToWEBPResponse, ApiConnectionActionConfiguration> PDFToWEBP(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToWEBPResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/webp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyinline != null)
                {
                    body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToWEBPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTIFFResponse, ApiConnectionActionConfiguration> PDFToTIFF(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyrect = WorkflowExpression.Compile(bodyrect, nameof(bodyrect), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFToTIFFResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/tiff";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyinline != null)
                {
                    body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyrect != null)
                {
                    body["rect"] = ExpressionConverter.ConvertO(__workflow_bodyrect);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFToTIFFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromCSVResponse, ApiConnectionActionConfiguration> PDFFromCSV(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFFromCSVResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFFromCSVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromDocResponse, ApiConnectionActionConfiguration> PDFFromDoc(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFFromDocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/doc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFFromDocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromImagesResponse, ApiConnectionActionConfiguration> PDFFromImages(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFFromImagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFFromImagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromEmailResponse, ApiConnectionActionConfiguration> PDFFromEmail(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyembedAttachments = null, Expression<Func<bool>> bodyconvertAttachments = null, Expression<Func<string>> bodymargins = null, Expression<Func<string>> bodypaperSize = null, Expression<Func<bodyorientationInput>> bodyorientation = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyembedAttachments = WorkflowExpression.Compile(bodyembedAttachments, nameof(bodyembedAttachments), required: false);
            var __workflow_bodyconvertAttachments = WorkflowExpression.Compile(bodyconvertAttachments, nameof(bodyconvertAttachments), required: false);
            var __workflow_bodymargins = WorkflowExpression.Compile(bodymargins, nameof(bodymargins), required: false);
            var __workflow_bodypaperSize = WorkflowExpression.Compile(bodypaperSize, nameof(bodypaperSize), required: false);
            var __workflow_bodyorientation = WorkflowExpression.Compile(bodyorientation, nameof(bodyorientation), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFFromEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyembedAttachments != null)
                {
                    body["embedAttachments"] = ExpressionConverter.ConvertO(__workflow_bodyembedAttachments);
                    bodypropCount++;
                }

                if (__workflow_bodyconvertAttachments != null)
                {
                    body["convertAttachments"] = ExpressionConverter.ConvertO(__workflow_bodyconvertAttachments);
                    bodypropCount++;
                }

                if (__workflow_bodymargins != null)
                {
                    body["margins"] = ExpressionConverter.ConvertO(__workflow_bodymargins);
                    bodypropCount++;
                }

                if (__workflow_bodypaperSize != null)
                {
                    body["paperSize"] = ExpressionConverter.ConvertO(__workflow_bodypaperSize);
                    bodypropCount++;
                }

                if (__workflow_bodyorientation != null)
                {
                    body["orientation"] = ExpressionConverter.ConvertO(__workflow_bodyorientation);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFFromEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAddSecurityResponse, ApiConnectionActionConfiguration> PDFAddSecurity(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyownerPassword, Expression<Func<string>> bodyuserPassword = null, Expression<Func<bodyencryptionAlgorithmInput>> bodyencryptionAlgorithm = null, Expression<Func<bool>> bodyallowAccessibilitySupport = null, Expression<Func<bool>> bodyallowAssemblyDocument = null, Expression<Func<bool>> bodyallowPrintDocument = null, Expression<Func<bool>> bodyallowFillForms = null, Expression<Func<bool>> bodyallowModifyDocument = null, Expression<Func<bool>> bodyallowContentExtraction = null, Expression<Func<bool>> bodyallowModifyAnnotations = null, Expression<Func<bodyprintQualityInput>> bodyprintQuality = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyownerPassword = WorkflowExpression.Compile(bodyownerPassword, nameof(bodyownerPassword), required: true);
            var __workflow_bodyuserPassword = WorkflowExpression.Compile(bodyuserPassword, nameof(bodyuserPassword), required: false);
            var __workflow_bodyencryptionAlgorithm = WorkflowExpression.Compile(bodyencryptionAlgorithm, nameof(bodyencryptionAlgorithm), required: false);
            var __workflow_bodyallowAccessibilitySupport = WorkflowExpression.Compile(bodyallowAccessibilitySupport, nameof(bodyallowAccessibilitySupport), required: false);
            var __workflow_bodyallowAssemblyDocument = WorkflowExpression.Compile(bodyallowAssemblyDocument, nameof(bodyallowAssemblyDocument), required: false);
            var __workflow_bodyallowPrintDocument = WorkflowExpression.Compile(bodyallowPrintDocument, nameof(bodyallowPrintDocument), required: false);
            var __workflow_bodyallowFillForms = WorkflowExpression.Compile(bodyallowFillForms, nameof(bodyallowFillForms), required: false);
            var __workflow_bodyallowModifyDocument = WorkflowExpression.Compile(bodyallowModifyDocument, nameof(bodyallowModifyDocument), required: false);
            var __workflow_bodyallowContentExtraction = WorkflowExpression.Compile(bodyallowContentExtraction, nameof(bodyallowContentExtraction), required: false);
            var __workflow_bodyallowModifyAnnotations = WorkflowExpression.Compile(bodyallowModifyAnnotations, nameof(bodyallowModifyAnnotations), required: false);
            var __workflow_bodyprintQuality = WorkflowExpression.Compile(bodyprintQuality, nameof(bodyprintQuality), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFAddSecurityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/security/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["ownerPassword"] = ExpressionConverter.ConvertO(__workflow_bodyownerPassword);
                if (__workflow_bodyuserPassword != null)
                {
                    body["userPassword"] = ExpressionConverter.ConvertO(__workflow_bodyuserPassword);
                    bodypropCount++;
                }

                if (__workflow_bodyencryptionAlgorithm != null)
                {
                    body["encryptionAlgorithm"] = ExpressionConverter.ConvertO(__workflow_bodyencryptionAlgorithm);
                    bodypropCount++;
                }

                if (__workflow_bodyallowAccessibilitySupport != null)
                {
                    body["allowAccessibilitySupport"] = ExpressionConverter.ConvertO(__workflow_bodyallowAccessibilitySupport);
                    bodypropCount++;
                }

                if (__workflow_bodyallowAssemblyDocument != null)
                {
                    body["allowAssemblyDocument"] = ExpressionConverter.ConvertO(__workflow_bodyallowAssemblyDocument);
                    bodypropCount++;
                }

                if (__workflow_bodyallowPrintDocument != null)
                {
                    body["allowPrintDocument"] = ExpressionConverter.ConvertO(__workflow_bodyallowPrintDocument);
                    bodypropCount++;
                }

                if (__workflow_bodyallowFillForms != null)
                {
                    body["allowFillForms"] = ExpressionConverter.ConvertO(__workflow_bodyallowFillForms);
                    bodypropCount++;
                }

                if (__workflow_bodyallowModifyDocument != null)
                {
                    body["allowModifyDocument"] = ExpressionConverter.ConvertO(__workflow_bodyallowModifyDocument);
                    bodypropCount++;
                }

                if (__workflow_bodyallowContentExtraction != null)
                {
                    body["allowContentExtraction"] = ExpressionConverter.ConvertO(__workflow_bodyallowContentExtraction);
                    bodypropCount++;
                }

                if (__workflow_bodyallowModifyAnnotations != null)
                {
                    body["allowModifyAnnotations"] = ExpressionConverter.ConvertO(__workflow_bodyallowModifyAnnotations);
                    bodypropCount++;
                }

                if (__workflow_bodyprintQuality != null)
                {
                    body["printQuality"] = ExpressionConverter.ConvertO(__workflow_bodyprintQuality);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFAddSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSecurityRemoveResponse, ApiConnectionActionConfiguration> PDFSecurityRemove(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypassword, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFSecurityRemoveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/security/remove";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFSecurityRemoveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromXLSXLSXResponse, ApiConnectionActionConfiguration> PDFFromXLSXLSX(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyworksheetIndex = WorkflowExpression.Compile(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<PDFFromXLSXLSXResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyworksheetIndex != null)
                {
                    if (__workflow_bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = ExpressionConverter.ConvertO(__workflow_bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFFromXLSXLSXResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoCSVResponse, ApiConnectionActionConfiguration> XLStoCSV(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyquotationSymbol = null, Expression<Func<string>> bodyseparatorSymbol = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyworksheetIndex = WorkflowExpression.Compile(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            var __workflow_bodyquotationSymbol = WorkflowExpression.Compile(bodyquotationSymbol, nameof(bodyquotationSymbol), required: false);
            var __workflow_bodyseparatorSymbol = WorkflowExpression.Compile(bodyseparatorSymbol, nameof(bodyseparatorSymbol), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<XLStoCSVResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyworksheetIndex != null)
                {
                    if (__workflow_bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = ExpressionConverter.ConvertO(__workflow_bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (__workflow_bodyquotationSymbol != null)
                {
                    body["quotationSymbol"] = ExpressionConverter.ConvertO(__workflow_bodyquotationSymbol);
                    bodypropCount++;
                }

                if (__workflow_bodyseparatorSymbol != null)
                {
                    body["separatorSymbol"] = ExpressionConverter.ConvertO(__workflow_bodyseparatorSymbol);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<XLStoCSVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoJSONResponse, ApiConnectionActionConfiguration> XLStoJSON(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyworksheetIndex = WorkflowExpression.Compile(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<XLStoJSONResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyworksheetIndex != null)
                {
                    if (__workflow_bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = ExpressionConverter.ConvertO(__workflow_bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<XLStoJSONResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoHTMLResponse, ApiConnectionActionConfiguration> XLStoHTML(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyworksheetIndex = WorkflowExpression.Compile(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<XLStoHTMLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyworksheetIndex != null)
                {
                    if (__workflow_bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = ExpressionConverter.ConvertO(__workflow_bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<XLStoHTMLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoTXTResponse, ApiConnectionActionConfiguration> XLStoTXT(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyworksheetIndex = WorkflowExpression.Compile(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<XLStoTXTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/txt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyworksheetIndex != null)
                {
                    if (__workflow_bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = ExpressionConverter.ConvertO(__workflow_bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<XLStoTXTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoXMLResponse, ApiConnectionActionConfiguration> XLStoXML(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyworksheetIndex = WorkflowExpression.Compile(bodyworksheetIndex, nameof(bodyworksheetIndex), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredBodyAction<XLStoXMLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyworksheetIndex != null)
                {
                    if (__workflow_bodyworksheetIndex != null)
                    {
                        body["worksheetIndex"] = ExpressionConverter.ConvertO(__workflow_bodyworksheetIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetIndex"] = "0";
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<XLStoXMLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFRotatePagesResponse, ApiConnectionActionConfiguration> PDFRotatePages(Expression<Func<string>> bodyurl, Expression<Func<bodyangleInput>> bodyangle = null, Expression<Func<string>> bodypages = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyangle = WorkflowExpression.Compile(bodyangle, nameof(bodyangle), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<PDFRotatePagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/rotate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyangle != null)
                {
                    body["angle"] = ExpressionConverter.ConvertO(__workflow_bodyangle);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<PDFRotatePagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAutoRotatePagesResponse, ApiConnectionActionConfiguration> PDFAutoRotatePages(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodylang = WorkflowExpression.Compile(bodylang, nameof(bodylang), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<PDFAutoRotatePagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/rotate/auto";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodylang != null)
                {
                    if (__workflow_bodylang != null)
                    {
                        body["lang"] = ExpressionConverter.ConvertO(__workflow_bodylang);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["lang"] = "eng";
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<PDFAutoRotatePagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFDeletePagesResponse, ApiConnectionActionConfiguration> PDFDeletePages(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<PDFDeletePagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/delete-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<PDFDeletePagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFCompressResponse, ApiConnectionActionConfiguration> PDFCompress(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<PDFCompressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/optimize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<PDFCompressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFClassifierResponse, ApiConnectionActionConfiguration> PDFClassifier(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyrulescsv = null, Expression<Func<string>> bodyrulescsvurl = null, Expression<Func<bool>> bodycaseSensitive = null, Expression<Func<bool>> bodyinline = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyrulescsv = WorkflowExpression.Compile(bodyrulescsv, nameof(bodyrulescsv), required: false);
            var __workflow_bodyrulescsvurl = WorkflowExpression.Compile(bodyrulescsvurl, nameof(bodyrulescsvurl), required: false);
            var __workflow_bodycaseSensitive = WorkflowExpression.Compile(bodycaseSensitive, nameof(bodycaseSensitive), required: false);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<PDFClassifierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/classifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyrulescsv != null)
                {
                    body["rulescsv"] = ExpressionConverter.ConvertO(__workflow_bodyrulescsv);
                    bodypropCount++;
                }

                if (__workflow_bodyrulescsvurl != null)
                {
                    body["rulescsvurl"] = ExpressionConverter.ConvertO(__workflow_bodyrulescsvurl);
                    bodypropCount++;
                }

                if (__workflow_bodycaseSensitive != null)
                {
                    if (__workflow_bodycaseSensitive != null)
                    {
                        body["caseSensitive"] = ExpressionConverter.ConvertO(__workflow_bodycaseSensitive);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["caseSensitive"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<PDFClassifierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailSendResponse, ApiConnectionActionConfiguration> EmailSend(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodysubject, Expression<Func<string>> bodysmtpserver, Expression<Func<string>> bodysmtpport, Expression<Func<string>> bodysmtpusername, Expression<Func<string>> bodysmtppassword, Expression<Func<string>> bodybodytext = null, Expression<Func<string>> bodybodyhtml = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: true);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodysmtpserver = WorkflowExpression.Compile(bodysmtpserver, nameof(bodysmtpserver), required: true);
            var __workflow_bodysmtpport = WorkflowExpression.Compile(bodysmtpport, nameof(bodysmtpport), required: true);
            var __workflow_bodysmtpusername = WorkflowExpression.Compile(bodysmtpusername, nameof(bodysmtpusername), required: true);
            var __workflow_bodysmtppassword = WorkflowExpression.Compile(bodysmtppassword, nameof(bodysmtppassword), required: true);
            var __workflow_bodybodytext = WorkflowExpression.Compile(bodybodytext, nameof(bodybodytext), required: false);
            var __workflow_bodybodyhtml = WorkflowExpression.Compile(bodybodyhtml, nameof(bodybodyhtml), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<EmailSendResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/email/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                if (__workflow_bodybodytext != null)
                {
                    body["bodytext"] = ExpressionConverter.ConvertO(__workflow_bodybodytext);
                    bodypropCount++;
                }

                if (__workflow_bodybodyhtml != null)
                {
                    body["bodyhtml"] = ExpressionConverter.ConvertO(__workflow_bodybodyhtml);
                    bodypropCount++;
                }

                bodypropCount++;
                body["smtpserver"] = ExpressionConverter.ConvertO(__workflow_bodysmtpserver);
                bodypropCount++;
                body["smtpport"] = ExpressionConverter.ConvertO(__workflow_bodysmtpport);
                bodypropCount++;
                body["smtpusername"] = ExpressionConverter.ConvertO(__workflow_bodysmtpusername);
                bodypropCount++;
                body["smtppassword"] = ExpressionConverter.ConvertO(__workflow_bodysmtppassword);
                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<EmailSendResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailDecodeResponse, ApiConnectionActionConfiguration> EmailDecode(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<EmailDecodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/email/decode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<EmailDecodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailAttachmentExtractionResponse, ApiConnectionActionConfiguration> EmailAttachmentExtraction(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<EmailAttachmentExtractionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/email/extract-attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<EmailAttachmentExtractionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAttachmentExtractionResponse, ApiConnectionActionConfiguration> PDFAttachmentExtraction(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyinline = WorkflowExpression.Compile(bodyinline, nameof(bodyinline), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: false);
            return new DeferredBodyAction<PDFAttachmentExtractionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/attachments/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodyinline != null)
                {
                    if (__workflow_bodyinline != null)
                    {
                        body["inline"] = ExpressionConverter.ConvertO(__workflow_bodyinline);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["inline"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    if (__workflow_bodyexpiration != null)
                    {
                        body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expiration"] = 60;
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (__workflow_bodyasync != null)
                {
                    if (__workflow_bodyasync != null)
                    {
                        body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
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

                return new ApiConnectionAction<PDFAttachmentExtractionResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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