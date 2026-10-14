//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfv2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Ilovepdfv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<CompressResponse> Compress(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodycompressionLevelInput>> bodycompressionLevel = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodycompressionLevel = bodycompressionLevel == null ? null : WorkflowExpression.Compile(bodycompressionLevel);
            WorkflowExpression.Validate(__workflow_bodycompressionLevel, nameof(bodycompressionLevel), required: false);
            return new DeferredBodyAction<CompressResponse>(() =>
            {
                var apiCallPath = "/compress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodycompressionLevel != null)
                {
                    body["compression_level"] = ExpressionConverter.ConvertO(__workflow_bodycompressionLevel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CompressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<SplitResponse> Split(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<bodysplitModeInput>> bodysplitMode, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyranges = null, Expression<Func<string>> bodyfixedRange = null, Expression<Func<string>> bodyremovePages = null, Expression<Func<bodymergeAfterInput>> bodymergeAfter = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodysplitMode = bodysplitMode == null ? null : WorkflowExpression.Compile(bodysplitMode);
            WorkflowExpression.Validate(__workflow_bodysplitMode, nameof(bodysplitMode), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyranges = bodyranges == null ? null : WorkflowExpression.Compile(bodyranges);
            WorkflowExpression.Validate(__workflow_bodyranges, nameof(bodyranges), required: false);
            var __workflow_bodyfixedRange = bodyfixedRange == null ? null : WorkflowExpression.Compile(bodyfixedRange);
            WorkflowExpression.Validate(__workflow_bodyfixedRange, nameof(bodyfixedRange), required: false);
            var __workflow_bodyremovePages = bodyremovePages == null ? null : WorkflowExpression.Compile(bodyremovePages);
            WorkflowExpression.Validate(__workflow_bodyremovePages, nameof(bodyremovePages), required: false);
            var __workflow_bodymergeAfter = bodymergeAfter == null ? null : WorkflowExpression.Compile(bodymergeAfter);
            WorkflowExpression.Validate(__workflow_bodymergeAfter, nameof(bodymergeAfter), required: false);
            return new DeferredBodyAction<SplitResponse>(() =>
            {
                var apiCallPath = "/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["split_mode"] = ExpressionConverter.ConvertO(__workflow_bodysplitMode);
                if (__workflow_bodyranges != null)
                {
                    body["ranges"] = ExpressionConverter.ConvertO(__workflow_bodyranges);
                    bodypropCount++;
                }

                if (__workflow_bodyfixedRange != null)
                {
                    body["fixed_range"] = ExpressionConverter.ConvertO(__workflow_bodyfixedRange);
                    bodypropCount++;
                }

                if (__workflow_bodyremovePages != null)
                {
                    body["remove_pages"] = ExpressionConverter.ConvertO(__workflow_bodyremovePages);
                    bodypropCount++;
                }

                if (__workflow_bodymergeAfter != null)
                {
                    body["merge_after"] = ExpressionConverter.ConvertO(__workflow_bodymergeAfter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SplitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<ProtectResponse> Protect(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodypassword, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodypassword = bodypassword == null ? null : WorkflowExpression.Compile(bodypassword);
            WorkflowExpression.Validate(__workflow_bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            return new DeferredBodyAction<ProtectResponse>(() =>
            {
                var apiCallPath = "/protect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProtectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<PDFtoJPGResponse> PDFtoJPG(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodypdfjpgModeInput>> bodypdfjpgMode = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodypdfjpgMode = bodypdfjpgMode == null ? null : WorkflowExpression.Compile(bodypdfjpgMode);
            WorkflowExpression.Validate(__workflow_bodypdfjpgMode, nameof(bodypdfjpgMode), required: false);
            return new DeferredBodyAction<PDFtoJPGResponse>(() =>
            {
                var apiCallPath = "/pdftojpg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodypdfjpgMode != null)
                {
                    body["pdfjpg_mode"] = ExpressionConverter.ConvertO(__workflow_bodypdfjpgMode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFtoJPGResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<ImageToPDFResponse> ImageToPDF(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyorientation = null, Expression<Func<string>> bodymargin = null, Expression<Func<bodypagesizeInput>> bodypagesize = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyorientation = bodyorientation == null ? null : WorkflowExpression.Compile(bodyorientation);
            WorkflowExpression.Validate(__workflow_bodyorientation, nameof(bodyorientation), required: false);
            var __workflow_bodymargin = bodymargin == null ? null : WorkflowExpression.Compile(bodymargin);
            WorkflowExpression.Validate(__workflow_bodymargin, nameof(bodymargin), required: false);
            var __workflow_bodypagesize = bodypagesize == null ? null : WorkflowExpression.Compile(bodypagesize);
            WorkflowExpression.Validate(__workflow_bodypagesize, nameof(bodypagesize), required: false);
            return new DeferredBodyAction<ImageToPDFResponse>(() =>
            {
                var apiCallPath = "/jpgtoimg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyorientation != null)
                {
                    body["orientation"] = ExpressionConverter.ConvertO(__workflow_bodyorientation);
                    bodypropCount++;
                }

                if (__workflow_bodymargin != null)
                {
                    body["margin"] = ExpressionConverter.ConvertO(__workflow_bodymargin);
                    bodypropCount++;
                }

                if (__workflow_bodypagesize != null)
                {
                    body["pagesize"] = ExpressionConverter.ConvertO(__workflow_bodypagesize);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImageToPDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<PDFtoPDFAResponse> PDFtoPDFA(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyconformanceInput>> bodyconformance = null, Expression<Func<bodyallowDowngradeInput>> bodyallowDowngrade = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyconformance = bodyconformance == null ? null : WorkflowExpression.Compile(bodyconformance);
            WorkflowExpression.Validate(__workflow_bodyconformance, nameof(bodyconformance), required: false);
            var __workflow_bodyallowDowngrade = bodyallowDowngrade == null ? null : WorkflowExpression.Compile(bodyallowDowngrade);
            WorkflowExpression.Validate(__workflow_bodyallowDowngrade, nameof(bodyallowDowngrade), required: false);
            return new DeferredBodyAction<PDFtoPDFAResponse>(() =>
            {
                var apiCallPath = "/pdftopdfa";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyconformance != null)
                {
                    body["conformance"] = ExpressionConverter.ConvertO(__workflow_bodyconformance);
                    bodypropCount++;
                }

                if (__workflow_bodyallowDowngrade != null)
                {
                    body["allow_downgrade"] = ExpressionConverter.ConvertO(__workflow_bodyallowDowngrade);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFtoPDFAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<UnlockResponse> Unlock(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodypassword = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodypassword = bodypassword == null ? null : WorkflowExpression.Compile(bodypassword);
            WorkflowExpression.Validate(__workflow_bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<UnlockResponse>(() =>
            {
                var apiCallPath = "/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
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

                return new ApiConnectionAction<UnlockResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<AddPageNumberResponse> AddPageNumber(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyfacingPagesInput>> bodyfacingPages = null, Expression<Func<bodyfirstCoverInput>> bodyfirstCover = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodystartingNumber = null, Expression<Func<bodyverticalPositionInput>> bodyverticalPosition = null, Expression<Func<bodyhorizontalPositionInput>> bodyhorizontalPosition = null, Expression<Func<string>> bodyverticalPositionAdjustment = null, Expression<Func<string>> bodyhorizontalPositionAdjustment = null, Expression<Func<bodyfontFamilyInput>> bodyfontFamily = null, Expression<Func<string>> bodyfontSize = null, Expression<Func<string>> bodyfontColor = null, Expression<Func<string>> bodytext = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyfacingPages = bodyfacingPages == null ? null : WorkflowExpression.Compile(bodyfacingPages);
            WorkflowExpression.Validate(__workflow_bodyfacingPages, nameof(bodyfacingPages), required: false);
            var __workflow_bodyfirstCover = bodyfirstCover == null ? null : WorkflowExpression.Compile(bodyfirstCover);
            WorkflowExpression.Validate(__workflow_bodyfirstCover, nameof(bodyfirstCover), required: false);
            var __workflow_bodypages = bodypages == null ? null : WorkflowExpression.Compile(bodypages);
            WorkflowExpression.Validate(__workflow_bodypages, nameof(bodypages), required: false);
            var __workflow_bodystartingNumber = bodystartingNumber == null ? null : WorkflowExpression.Compile(bodystartingNumber);
            WorkflowExpression.Validate(__workflow_bodystartingNumber, nameof(bodystartingNumber), required: false);
            var __workflow_bodyverticalPosition = bodyverticalPosition == null ? null : WorkflowExpression.Compile(bodyverticalPosition);
            WorkflowExpression.Validate(__workflow_bodyverticalPosition, nameof(bodyverticalPosition), required: false);
            var __workflow_bodyhorizontalPosition = bodyhorizontalPosition == null ? null : WorkflowExpression.Compile(bodyhorizontalPosition);
            WorkflowExpression.Validate(__workflow_bodyhorizontalPosition, nameof(bodyhorizontalPosition), required: false);
            var __workflow_bodyverticalPositionAdjustment = bodyverticalPositionAdjustment == null ? null : WorkflowExpression.Compile(bodyverticalPositionAdjustment);
            WorkflowExpression.Validate(__workflow_bodyverticalPositionAdjustment, nameof(bodyverticalPositionAdjustment), required: false);
            var __workflow_bodyhorizontalPositionAdjustment = bodyhorizontalPositionAdjustment == null ? null : WorkflowExpression.Compile(bodyhorizontalPositionAdjustment);
            WorkflowExpression.Validate(__workflow_bodyhorizontalPositionAdjustment, nameof(bodyhorizontalPositionAdjustment), required: false);
            var __workflow_bodyfontFamily = bodyfontFamily == null ? null : WorkflowExpression.Compile(bodyfontFamily);
            WorkflowExpression.Validate(__workflow_bodyfontFamily, nameof(bodyfontFamily), required: false);
            var __workflow_bodyfontSize = bodyfontSize == null ? null : WorkflowExpression.Compile(bodyfontSize);
            WorkflowExpression.Validate(__workflow_bodyfontSize, nameof(bodyfontSize), required: false);
            var __workflow_bodyfontColor = bodyfontColor == null ? null : WorkflowExpression.Compile(bodyfontColor);
            WorkflowExpression.Validate(__workflow_bodyfontColor, nameof(bodyfontColor), required: false);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: false);
            return new DeferredBodyAction<AddPageNumberResponse>(() =>
            {
                var apiCallPath = "/pagenumber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyfacingPages != null)
                {
                    body["facing_pages"] = ExpressionConverter.ConvertO(__workflow_bodyfacingPages);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstCover != null)
                {
                    body["first_cover"] = ExpressionConverter.ConvertO(__workflow_bodyfirstCover);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodystartingNumber != null)
                {
                    body["starting_number"] = ExpressionConverter.ConvertO(__workflow_bodystartingNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyverticalPosition != null)
                {
                    body["vertical_position"] = ExpressionConverter.ConvertO(__workflow_bodyverticalPosition);
                    bodypropCount++;
                }

                if (__workflow_bodyhorizontalPosition != null)
                {
                    body["horizontal_position"] = ExpressionConverter.ConvertO(__workflow_bodyhorizontalPosition);
                    bodypropCount++;
                }

                if (__workflow_bodyverticalPositionAdjustment != null)
                {
                    body["vertical_position_adjustment"] = ExpressionConverter.ConvertO(__workflow_bodyverticalPositionAdjustment);
                    bodypropCount++;
                }

                if (__workflow_bodyhorizontalPositionAdjustment != null)
                {
                    body["horizontal_position_adjustment"] = ExpressionConverter.ConvertO(__workflow_bodyhorizontalPositionAdjustment);
                    bodypropCount++;
                }

                if (__workflow_bodyfontFamily != null)
                {
                    body["font_family"] = ExpressionConverter.ConvertO(__workflow_bodyfontFamily);
                    bodypropCount++;
                }

                if (__workflow_bodyfontSize != null)
                {
                    body["font_size"] = ExpressionConverter.ConvertO(__workflow_bodyfontSize);
                    bodypropCount++;
                }

                if (__workflow_bodyfontColor != null)
                {
                    body["font_color"] = ExpressionConverter.ConvertO(__workflow_bodyfontColor);
                    bodypropCount++;
                }

                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddPageNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<MergeResponse> Merge(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyfileSource2Input>> bodyfileSource2 = null, Expression<Func<string>> bodyfileName2 = null, Expression<Func<string>> bodyfile2 = null, Expression<Func<string>> bodyfileUrl2 = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyfileSource2 = bodyfileSource2 == null ? null : WorkflowExpression.Compile(bodyfileSource2);
            WorkflowExpression.Validate(__workflow_bodyfileSource2, nameof(bodyfileSource2), required: false);
            var __workflow_bodyfileName2 = bodyfileName2 == null ? null : WorkflowExpression.Compile(bodyfileName2);
            WorkflowExpression.Validate(__workflow_bodyfileName2, nameof(bodyfileName2), required: false);
            var __workflow_bodyfile2 = bodyfile2 == null ? null : WorkflowExpression.Compile(bodyfile2);
            WorkflowExpression.Validate(__workflow_bodyfile2, nameof(bodyfile2), required: false);
            var __workflow_bodyfileUrl2 = bodyfileUrl2 == null ? null : WorkflowExpression.Compile(bodyfileUrl2);
            WorkflowExpression.Validate(__workflow_bodyfileUrl2, nameof(bodyfileUrl2), required: false);
            return new DeferredBodyAction<MergeResponse>(() =>
            {
                var apiCallPath = "/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyfileSource2 != null)
                {
                    body["file_source2"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource2);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName2 != null)
                {
                    body["file_name2"] = ExpressionConverter.ConvertO(__workflow_bodyfileName2);
                    bodypropCount++;
                }

                if (__workflow_bodyfile2 != null)
                {
                    body["file2"] = ExpressionConverter.ConvertO(__workflow_bodyfile2);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl2 != null)
                {
                    body["file_url2"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl2);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<WatermarkResponse> Watermark(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodymodeInput>> bodymode = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyimageSource = null, Expression<Func<string>> bodyimageName = null, Expression<Func<string>> bodyimageFile = null, Expression<Func<string>> bodyimageUrl = null, Expression<Func<string>> bodypages = null, Expression<Func<bodyverticalPositionInput>> bodyverticalPosition = null, Expression<Func<bodyhorizontalPositionInput>> bodyhorizontalPosition = null, Expression<Func<string>> bodyverticalPositionAdjustment = null, Expression<Func<string>> bodyhorizontalPositionAdjustment = null, Expression<Func<bodymosaicInput>> bodymosaic = null, Expression<Func<string>> bodyrotation = null, Expression<Func<bodyfontFamilyInput>> bodyfontFamily = null, Expression<Func<bodyfontStyleInput>> bodyfontStyle = null, Expression<Func<string>> bodyfontSize = null, Expression<Func<string>> bodyfontColor = null, Expression<Func<string>> bodytransparency = null, Expression<Func<bodylayerInput>> bodylayer = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodymode = bodymode == null ? null : WorkflowExpression.Compile(bodymode);
            WorkflowExpression.Validate(__workflow_bodymode, nameof(bodymode), required: false);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: false);
            var __workflow_bodyimageSource = bodyimageSource == null ? null : WorkflowExpression.Compile(bodyimageSource);
            WorkflowExpression.Validate(__workflow_bodyimageSource, nameof(bodyimageSource), required: false);
            var __workflow_bodyimageName = bodyimageName == null ? null : WorkflowExpression.Compile(bodyimageName);
            WorkflowExpression.Validate(__workflow_bodyimageName, nameof(bodyimageName), required: false);
            var __workflow_bodyimageFile = bodyimageFile == null ? null : WorkflowExpression.Compile(bodyimageFile);
            WorkflowExpression.Validate(__workflow_bodyimageFile, nameof(bodyimageFile), required: false);
            var __workflow_bodyimageUrl = bodyimageUrl == null ? null : WorkflowExpression.Compile(bodyimageUrl);
            WorkflowExpression.Validate(__workflow_bodyimageUrl, nameof(bodyimageUrl), required: false);
            var __workflow_bodypages = bodypages == null ? null : WorkflowExpression.Compile(bodypages);
            WorkflowExpression.Validate(__workflow_bodypages, nameof(bodypages), required: false);
            var __workflow_bodyverticalPosition = bodyverticalPosition == null ? null : WorkflowExpression.Compile(bodyverticalPosition);
            WorkflowExpression.Validate(__workflow_bodyverticalPosition, nameof(bodyverticalPosition), required: false);
            var __workflow_bodyhorizontalPosition = bodyhorizontalPosition == null ? null : WorkflowExpression.Compile(bodyhorizontalPosition);
            WorkflowExpression.Validate(__workflow_bodyhorizontalPosition, nameof(bodyhorizontalPosition), required: false);
            var __workflow_bodyverticalPositionAdjustment = bodyverticalPositionAdjustment == null ? null : WorkflowExpression.Compile(bodyverticalPositionAdjustment);
            WorkflowExpression.Validate(__workflow_bodyverticalPositionAdjustment, nameof(bodyverticalPositionAdjustment), required: false);
            var __workflow_bodyhorizontalPositionAdjustment = bodyhorizontalPositionAdjustment == null ? null : WorkflowExpression.Compile(bodyhorizontalPositionAdjustment);
            WorkflowExpression.Validate(__workflow_bodyhorizontalPositionAdjustment, nameof(bodyhorizontalPositionAdjustment), required: false);
            var __workflow_bodymosaic = bodymosaic == null ? null : WorkflowExpression.Compile(bodymosaic);
            WorkflowExpression.Validate(__workflow_bodymosaic, nameof(bodymosaic), required: false);
            var __workflow_bodyrotation = bodyrotation == null ? null : WorkflowExpression.Compile(bodyrotation);
            WorkflowExpression.Validate(__workflow_bodyrotation, nameof(bodyrotation), required: false);
            var __workflow_bodyfontFamily = bodyfontFamily == null ? null : WorkflowExpression.Compile(bodyfontFamily);
            WorkflowExpression.Validate(__workflow_bodyfontFamily, nameof(bodyfontFamily), required: false);
            var __workflow_bodyfontStyle = bodyfontStyle == null ? null : WorkflowExpression.Compile(bodyfontStyle);
            WorkflowExpression.Validate(__workflow_bodyfontStyle, nameof(bodyfontStyle), required: false);
            var __workflow_bodyfontSize = bodyfontSize == null ? null : WorkflowExpression.Compile(bodyfontSize);
            WorkflowExpression.Validate(__workflow_bodyfontSize, nameof(bodyfontSize), required: false);
            var __workflow_bodyfontColor = bodyfontColor == null ? null : WorkflowExpression.Compile(bodyfontColor);
            WorkflowExpression.Validate(__workflow_bodyfontColor, nameof(bodyfontColor), required: false);
            var __workflow_bodytransparency = bodytransparency == null ? null : WorkflowExpression.Compile(bodytransparency);
            WorkflowExpression.Validate(__workflow_bodytransparency, nameof(bodytransparency), required: false);
            var __workflow_bodylayer = bodylayer == null ? null : WorkflowExpression.Compile(bodylayer);
            WorkflowExpression.Validate(__workflow_bodylayer, nameof(bodylayer), required: false);
            return new DeferredBodyAction<WatermarkResponse>(() =>
            {
                var apiCallPath = "/watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodymode != null)
                {
                    body["mode"] = ExpressionConverter.ConvertO(__workflow_bodymode);
                    bodypropCount++;
                }

                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodyimageSource != null)
                {
                    body["image_source"] = ExpressionConverter.ConvertO(__workflow_bodyimageSource);
                    bodypropCount++;
                }

                if (__workflow_bodyimageName != null)
                {
                    body["image_name"] = ExpressionConverter.ConvertO(__workflow_bodyimageName);
                    bodypropCount++;
                }

                if (__workflow_bodyimageFile != null)
                {
                    body["image_file"] = ExpressionConverter.ConvertO(__workflow_bodyimageFile);
                    bodypropCount++;
                }

                if (__workflow_bodyimageUrl != null)
                {
                    body["image_url"] = ExpressionConverter.ConvertO(__workflow_bodyimageUrl);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodyverticalPosition != null)
                {
                    body["vertical_position"] = ExpressionConverter.ConvertO(__workflow_bodyverticalPosition);
                    bodypropCount++;
                }

                if (__workflow_bodyhorizontalPosition != null)
                {
                    body["horizontal_position"] = ExpressionConverter.ConvertO(__workflow_bodyhorizontalPosition);
                    bodypropCount++;
                }

                if (__workflow_bodyverticalPositionAdjustment != null)
                {
                    body["vertical_position_adjustment"] = ExpressionConverter.ConvertO(__workflow_bodyverticalPositionAdjustment);
                    bodypropCount++;
                }

                if (__workflow_bodyhorizontalPositionAdjustment != null)
                {
                    body["horizontal_position_adjustment"] = ExpressionConverter.ConvertO(__workflow_bodyhorizontalPositionAdjustment);
                    bodypropCount++;
                }

                if (__workflow_bodymosaic != null)
                {
                    body["mosaic"] = ExpressionConverter.ConvertO(__workflow_bodymosaic);
                    bodypropCount++;
                }

                if (__workflow_bodyrotation != null)
                {
                    body["rotation"] = ExpressionConverter.ConvertO(__workflow_bodyrotation);
                    bodypropCount++;
                }

                if (__workflow_bodyfontFamily != null)
                {
                    body["font_family"] = ExpressionConverter.ConvertO(__workflow_bodyfontFamily);
                    bodypropCount++;
                }

                if (__workflow_bodyfontStyle != null)
                {
                    body["font_style"] = ExpressionConverter.ConvertO(__workflow_bodyfontStyle);
                    bodypropCount++;
                }

                if (__workflow_bodyfontSize != null)
                {
                    body["font_size"] = ExpressionConverter.ConvertO(__workflow_bodyfontSize);
                    bodypropCount++;
                }

                if (__workflow_bodyfontColor != null)
                {
                    body["font_color"] = ExpressionConverter.ConvertO(__workflow_bodyfontColor);
                    bodypropCount++;
                }

                if (__workflow_bodytransparency != null)
                {
                    body["transparency"] = ExpressionConverter.ConvertO(__workflow_bodytransparency);
                    bodypropCount++;
                }

                if (__workflow_bodylayer != null)
                {
                    body["layer"] = ExpressionConverter.ConvertO(__workflow_bodylayer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WatermarkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<RotateResponse> Rotate(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyrotateInput>> bodyrotate = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyrotate = bodyrotate == null ? null : WorkflowExpression.Compile(bodyrotate);
            WorkflowExpression.Validate(__workflow_bodyrotate, nameof(bodyrotate), required: false);
            return new DeferredBodyAction<RotateResponse>(() =>
            {
                var apiCallPath = "/rotate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyrotate != null)
                {
                    body["rotate"] = ExpressionConverter.ConvertO(__workflow_bodyrotate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RotateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<PDFOCRResponse> PDFOCR(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyocrLanguages = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyocrLanguages = bodyocrLanguages == null ? null : WorkflowExpression.Compile(bodyocrLanguages);
            WorkflowExpression.Validate(__workflow_bodyocrLanguages, nameof(bodyocrLanguages), required: false);
            return new DeferredBodyAction<PDFOCRResponse>(() =>
            {
                var apiCallPath = "/pdfocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyocrLanguages != null)
                {
                    body["ocr_languages"] = ExpressionConverter.ConvertO(__workflow_bodyocrLanguages);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PDFOCRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<OfficeToPDFResponse> OfficeToPDF(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null)
        {
            var __workflow_bodyfileSource = bodyfileSource == null ? null : WorkflowExpression.Compile(bodyfileSource);
            WorkflowExpression.Validate(__workflow_bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = bodyfile == null ? null : WorkflowExpression.Compile(bodyfile);
            WorkflowExpression.Validate(__workflow_bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = bodyfileUrl == null ? null : WorkflowExpression.Compile(bodyfileUrl);
            WorkflowExpression.Validate(__workflow_bodyfileUrl, nameof(bodyfileUrl), required: false);
            return new DeferredBodyAction<OfficeToPDFResponse>(() =>
            {
                var apiCallPath = "/officetopdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OfficeToPDFResponse>(callPayload);
            });
        }
    }

    public class Ilovepdfv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class CompressResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfileSourceInput
    {
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "url")]
        Url
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycompressionLevelInput
    {
        [EnumMember(Value = "extreme")]
        Extreme,
        [EnumMember(Value = "recommended")]
        Recommended,
        [EnumMember(Value = "low")]
        Low
    }

    public class SplitResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysplitModeInput
    {
        [EnumMember(Value = "fixed_ranges")]
        FixedRanges,
        [EnumMember(Value = "ranges")]
        Ranges,
        [EnumMember(Value = "fixed_range")]
        FixedRange,
        [EnumMember(Value = "remove_pages")]
        RemovePages,
        [EnumMember(Value = "filesize")]
        Filesize
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymergeAfterInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class ProtectResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class PDFtoJPGResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypdfjpgModeInput
    {
        [EnumMember(Value = "pages")]
        Pages,
        [EnumMember(Value = "extract")]
        Extract
    }

    public class ImageToPDFResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypagesizeInput
    {
        [EnumMember(Value = "fit")]
        Fit,
        A4,
        [EnumMember(Value = "letter")]
        Letter
    }

    public class PDFtoPDFAResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyconformanceInput
    {
        [EnumMember(Value = "pdfa-1b")]
        Pdfa1b,
        [EnumMember(Value = "pdfa-1a")]
        Pdfa1a,
        [EnumMember(Value = "pdfa-2b")]
        Pdfa2b,
        [EnumMember(Value = "pdfa-2u")]
        Pdfa2u,
        [EnumMember(Value = "pdfa-2a")]
        Pdfa2a,
        [EnumMember(Value = "pdfa-3b")]
        Pdfa3b,
        [EnumMember(Value = "pdfa-3u")]
        Pdfa3u,
        [EnumMember(Value = "pdfa-3a")]
        Pdfa3a
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyallowDowngradeInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class UnlockResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class AddPageNumberResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfacingPagesInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfirstCoverInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyverticalPositionInput
    {
        [EnumMember(Value = "bottom")]
        Bottom,
        [EnumMember(Value = "middle")]
        Middle,
        [EnumMember(Value = "top")]
        Top
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyhorizontalPositionInput
    {
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "right")]
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfontFamilyInput
    {
        Arial,
        [EnumMember(Value = "Arial Unicode MS")]
        ArialUnicodeMS,
        Verdana,
        Courier,
        [EnumMember(Value = "Times New Roman")]
        TimesNewRoman,
        [EnumMember(Value = "Comic Sans MS")]
        ComicSansMS,
        [EnumMember(Value = "WenQuanYi Zen Hei")]
        WenQuanYiZenHei,
        [EnumMember(Value = "Lohit Marathi")]
        LohitMarathi
    }

    public class MergeResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfileSource2Input
    {
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "url")]
        Url
    }

    public class WatermarkResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymodeInput
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "image")]
        Image
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymosaicInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfontStyleInput
    {
        Bold,
        Italic
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylayerInput
    {
        [EnumMember(Value = "above")]
        Above,
        [EnumMember(Value = "below")]
        Below
    }

    public class RotateResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrotateInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "180")]
        _180,
        [EnumMember(Value = "270")]
        _270
    }

    public class PDFOCRResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class OfficeToPDFResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfv2;

    public partial class WorkflowManagedActions
    {
        public Ilovepdfv2Actions Ilovepdfv2(string connectionId) => new Ilovepdfv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Ilovepdfv2Triggers Ilovepdfv2(string connectionId) => new Ilovepdfv2Triggers(connectionId);
    }
}
