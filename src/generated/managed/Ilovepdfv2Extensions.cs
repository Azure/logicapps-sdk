//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfv2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ilovepdfv2Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [WorkflowExpressionFactory(nameof(__BuildCompress))]
        public IBodyWorkflowAction<CompressResponse> Compress([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodycompressionLevelInput> bodycompressionLevel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompressResponse> __BuildCompress(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<bodycompressionLevelInput> bodycompressionLevel = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodycompressionLevel, nameof(bodycompressionLevel), required: false);
            return new DeferredBodyAction<CompressResponse>(() =>
            {
                var apiCallPath = "/compress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodycompressionLevel != null)
                {
                    body["compression_level"] = ExpressionConverter.ConvertO(bodycompressionLevel);
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
        [WorkflowExpressionFactory(nameof(__BuildSplit))]
        public IBodyWorkflowAction<SplitResponse> Split([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<bodysplitModeInput> bodysplitMode, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyranges = null, [WorkflowExpression] Func<string> bodyfixedRange = null, [WorkflowExpression] Func<string> bodyremovePages = null, [WorkflowExpression] Func<bodymergeAfterInput> bodymergeAfter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SplitResponse> __BuildSplit(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<bodysplitModeInput> bodysplitMode, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<string> bodyranges = null, WorkflowExpression<string> bodyfixedRange = null, WorkflowExpression<string> bodyremovePages = null, WorkflowExpression<bodymergeAfterInput> bodymergeAfter = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodysplitMode, nameof(bodysplitMode), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodyranges, nameof(bodyranges), required: false);
            WorkflowExpression.Validate(bodyfixedRange, nameof(bodyfixedRange), required: false);
            WorkflowExpression.Validate(bodyremovePages, nameof(bodyremovePages), required: false);
            WorkflowExpression.Validate(bodymergeAfter, nameof(bodymergeAfter), required: false);
            return new DeferredBodyAction<SplitResponse>(() =>
            {
                var apiCallPath = "/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["split_mode"] = ExpressionConverter.ConvertO(bodysplitMode);
                if (bodyranges != null)
                {
                    body["ranges"] = ExpressionConverter.ConvertO(bodyranges);
                    bodypropCount++;
                }

                if (bodyfixedRange != null)
                {
                    body["fixed_range"] = ExpressionConverter.ConvertO(bodyfixedRange);
                    bodypropCount++;
                }

                if (bodyremovePages != null)
                {
                    body["remove_pages"] = ExpressionConverter.ConvertO(bodyremovePages);
                    bodypropCount++;
                }

                if (bodymergeAfter != null)
                {
                    body["merge_after"] = ExpressionConverter.ConvertO(bodymergeAfter);
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
        [WorkflowExpressionFactory(nameof(__BuildProtect))]
        public IBodyWorkflowAction<ProtectResponse> Protect([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProtectResponse> __BuildProtect(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodypassword, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            return new DeferredBodyAction<ProtectResponse>(() =>
            {
                var apiCallPath = "/protect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProtectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [WorkflowExpressionFactory(nameof(__BuildPDFtoJPG))]
        public IBodyWorkflowAction<PDFtoJPGResponse> PDFtoJPG([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodypdfjpgModeInput> bodypdfjpgMode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PDFtoJPGResponse> __BuildPDFtoJPG(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<bodypdfjpgModeInput> bodypdfjpgMode = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodypdfjpgMode, nameof(bodypdfjpgMode), required: false);
            return new DeferredBodyAction<PDFtoJPGResponse>(() =>
            {
                var apiCallPath = "/pdftojpg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodypdfjpgMode != null)
                {
                    body["pdfjpg_mode"] = ExpressionConverter.ConvertO(bodypdfjpgMode);
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
        [WorkflowExpressionFactory(nameof(__BuildImageToPDF))]
        public IBodyWorkflowAction<ImageToPDFResponse> ImageToPDF([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyorientation = null, [WorkflowExpression] Func<string> bodymargin = null, [WorkflowExpression] Func<bodypagesizeInput> bodypagesize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageToPDFResponse> __BuildImageToPDF(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<string> bodyorientation = null, WorkflowExpression<string> bodymargin = null, WorkflowExpression<bodypagesizeInput> bodypagesize = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodyorientation, nameof(bodyorientation), required: false);
            WorkflowExpression.Validate(bodymargin, nameof(bodymargin), required: false);
            WorkflowExpression.Validate(bodypagesize, nameof(bodypagesize), required: false);
            return new DeferredBodyAction<ImageToPDFResponse>(() =>
            {
                var apiCallPath = "/jpgtoimg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyorientation != null)
                {
                    body["orientation"] = ExpressionConverter.ConvertO(bodyorientation);
                    bodypropCount++;
                }

                if (bodymargin != null)
                {
                    body["margin"] = ExpressionConverter.ConvertO(bodymargin);
                    bodypropCount++;
                }

                if (bodypagesize != null)
                {
                    body["pagesize"] = ExpressionConverter.ConvertO(bodypagesize);
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
        [WorkflowExpressionFactory(nameof(__BuildPDFtoPDFA))]
        public IBodyWorkflowAction<PDFtoPDFAResponse> PDFtoPDFA([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyconformanceInput> bodyconformance = null, [WorkflowExpression] Func<bodyallowDowngradeInput> bodyallowDowngrade = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PDFtoPDFAResponse> __BuildPDFtoPDFA(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<bodyconformanceInput> bodyconformance = null, WorkflowExpression<bodyallowDowngradeInput> bodyallowDowngrade = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodyconformance, nameof(bodyconformance), required: false);
            WorkflowExpression.Validate(bodyallowDowngrade, nameof(bodyallowDowngrade), required: false);
            return new DeferredBodyAction<PDFtoPDFAResponse>(() =>
            {
                var apiCallPath = "/pdftopdfa";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyconformance != null)
                {
                    body["conformance"] = ExpressionConverter.ConvertO(bodyconformance);
                    bodypropCount++;
                }

                if (bodyallowDowngrade != null)
                {
                    body["allow_downgrade"] = ExpressionConverter.ConvertO(bodyallowDowngrade);
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
        [WorkflowExpressionFactory(nameof(__BuildUnlock))]
        public IBodyWorkflowAction<UnlockResponse> Unlock([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UnlockResponse> __BuildUnlock(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<string> bodypassword = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<UnlockResponse>(() =>
            {
                var apiCallPath = "/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(bodypassword);
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
        [WorkflowExpressionFactory(nameof(__BuildAddPageNumber))]
        public IBodyWorkflowAction<AddPageNumberResponse> AddPageNumber([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyfacingPagesInput> bodyfacingPages = null, [WorkflowExpression] Func<bodyfirstCoverInput> bodyfirstCover = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodystartingNumber = null, [WorkflowExpression] Func<bodyverticalPositionInput> bodyverticalPosition = null, [WorkflowExpression] Func<bodyhorizontalPositionInput> bodyhorizontalPosition = null, [WorkflowExpression] Func<string> bodyverticalPositionAdjustment = null, [WorkflowExpression] Func<string> bodyhorizontalPositionAdjustment = null, [WorkflowExpression] Func<bodyfontFamilyInput> bodyfontFamily = null, [WorkflowExpression] Func<string> bodyfontSize = null, [WorkflowExpression] Func<string> bodyfontColor = null, [WorkflowExpression] Func<string> bodytext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddPageNumberResponse> __BuildAddPageNumber(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<bodyfacingPagesInput> bodyfacingPages = null, WorkflowExpression<bodyfirstCoverInput> bodyfirstCover = null, WorkflowExpression<string> bodypages = null, WorkflowExpression<string> bodystartingNumber = null, WorkflowExpression<bodyverticalPositionInput> bodyverticalPosition = null, WorkflowExpression<bodyhorizontalPositionInput> bodyhorizontalPosition = null, WorkflowExpression<string> bodyverticalPositionAdjustment = null, WorkflowExpression<string> bodyhorizontalPositionAdjustment = null, WorkflowExpression<bodyfontFamilyInput> bodyfontFamily = null, WorkflowExpression<string> bodyfontSize = null, WorkflowExpression<string> bodyfontColor = null, WorkflowExpression<string> bodytext = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodyfacingPages, nameof(bodyfacingPages), required: false);
            WorkflowExpression.Validate(bodyfirstCover, nameof(bodyfirstCover), required: false);
            WorkflowExpression.Validate(bodypages, nameof(bodypages), required: false);
            WorkflowExpression.Validate(bodystartingNumber, nameof(bodystartingNumber), required: false);
            WorkflowExpression.Validate(bodyverticalPosition, nameof(bodyverticalPosition), required: false);
            WorkflowExpression.Validate(bodyhorizontalPosition, nameof(bodyhorizontalPosition), required: false);
            WorkflowExpression.Validate(bodyverticalPositionAdjustment, nameof(bodyverticalPositionAdjustment), required: false);
            WorkflowExpression.Validate(bodyhorizontalPositionAdjustment, nameof(bodyhorizontalPositionAdjustment), required: false);
            WorkflowExpression.Validate(bodyfontFamily, nameof(bodyfontFamily), required: false);
            WorkflowExpression.Validate(bodyfontSize, nameof(bodyfontSize), required: false);
            WorkflowExpression.Validate(bodyfontColor, nameof(bodyfontColor), required: false);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            return new DeferredBodyAction<AddPageNumberResponse>(() =>
            {
                var apiCallPath = "/pagenumber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyfacingPages != null)
                {
                    body["facing_pages"] = ExpressionConverter.ConvertO(bodyfacingPages);
                    bodypropCount++;
                }

                if (bodyfirstCover != null)
                {
                    body["first_cover"] = ExpressionConverter.ConvertO(bodyfirstCover);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(bodypages);
                    bodypropCount++;
                }

                if (bodystartingNumber != null)
                {
                    body["starting_number"] = ExpressionConverter.ConvertO(bodystartingNumber);
                    bodypropCount++;
                }

                if (bodyverticalPosition != null)
                {
                    body["vertical_position"] = ExpressionConverter.ConvertO(bodyverticalPosition);
                    bodypropCount++;
                }

                if (bodyhorizontalPosition != null)
                {
                    body["horizontal_position"] = ExpressionConverter.ConvertO(bodyhorizontalPosition);
                    bodypropCount++;
                }

                if (bodyverticalPositionAdjustment != null)
                {
                    body["vertical_position_adjustment"] = ExpressionConverter.ConvertO(bodyverticalPositionAdjustment);
                    bodypropCount++;
                }

                if (bodyhorizontalPositionAdjustment != null)
                {
                    body["horizontal_position_adjustment"] = ExpressionConverter.ConvertO(bodyhorizontalPositionAdjustment);
                    bodypropCount++;
                }

                if (bodyfontFamily != null)
                {
                    body["font_family"] = ExpressionConverter.ConvertO(bodyfontFamily);
                    bodypropCount++;
                }

                if (bodyfontSize != null)
                {
                    body["font_size"] = ExpressionConverter.ConvertO(bodyfontSize);
                    bodypropCount++;
                }

                if (bodyfontColor != null)
                {
                    body["font_color"] = ExpressionConverter.ConvertO(bodyfontColor);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
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
        [WorkflowExpressionFactory(nameof(__BuildMerge))]
        public IBodyWorkflowAction<MergeResponse> Merge([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyfileSource2Input> bodyfileSource2 = null, [WorkflowExpression] Func<string> bodyfileName2 = null, [WorkflowExpression] Func<string> bodyfile2 = null, [WorkflowExpression] Func<string> bodyfileUrl2 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeResponse> __BuildMerge(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<bodyfileSource2Input> bodyfileSource2 = null, WorkflowExpression<string> bodyfileName2 = null, WorkflowExpression<string> bodyfile2 = null, WorkflowExpression<string> bodyfileUrl2 = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodyfileSource2, nameof(bodyfileSource2), required: false);
            WorkflowExpression.Validate(bodyfileName2, nameof(bodyfileName2), required: false);
            WorkflowExpression.Validate(bodyfile2, nameof(bodyfile2), required: false);
            WorkflowExpression.Validate(bodyfileUrl2, nameof(bodyfileUrl2), required: false);
            return new DeferredBodyAction<MergeResponse>(() =>
            {
                var apiCallPath = "/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyfileSource2 != null)
                {
                    body["file_source2"] = ExpressionConverter.ConvertO(bodyfileSource2);
                    bodypropCount++;
                }

                if (bodyfileName2 != null)
                {
                    body["file_name2"] = ExpressionConverter.ConvertO(bodyfileName2);
                    bodypropCount++;
                }

                if (bodyfile2 != null)
                {
                    body["file2"] = ExpressionConverter.ConvertO(bodyfile2);
                    bodypropCount++;
                }

                if (bodyfileUrl2 != null)
                {
                    body["file_url2"] = ExpressionConverter.ConvertO(bodyfileUrl2);
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
        [WorkflowExpressionFactory(nameof(__BuildWatermark))]
        public IBodyWorkflowAction<WatermarkResponse> Watermark([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodymodeInput> bodymode = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyimageSource = null, [WorkflowExpression] Func<string> bodyimageName = null, [WorkflowExpression] Func<string> bodyimageFile = null, [WorkflowExpression] Func<string> bodyimageUrl = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<bodyverticalPositionInput> bodyverticalPosition = null, [WorkflowExpression] Func<bodyhorizontalPositionInput> bodyhorizontalPosition = null, [WorkflowExpression] Func<string> bodyverticalPositionAdjustment = null, [WorkflowExpression] Func<string> bodyhorizontalPositionAdjustment = null, [WorkflowExpression] Func<bodymosaicInput> bodymosaic = null, [WorkflowExpression] Func<string> bodyrotation = null, [WorkflowExpression] Func<bodyfontFamilyInput> bodyfontFamily = null, [WorkflowExpression] Func<bodyfontStyleInput> bodyfontStyle = null, [WorkflowExpression] Func<string> bodyfontSize = null, [WorkflowExpression] Func<string> bodyfontColor = null, [WorkflowExpression] Func<string> bodytransparency = null, [WorkflowExpression] Func<bodylayerInput> bodylayer = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WatermarkResponse> __BuildWatermark(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<bodymodeInput> bodymode = null, WorkflowExpression<string> bodytext = null, WorkflowExpression<string> bodyimageSource = null, WorkflowExpression<string> bodyimageName = null, WorkflowExpression<string> bodyimageFile = null, WorkflowExpression<string> bodyimageUrl = null, WorkflowExpression<string> bodypages = null, WorkflowExpression<bodyverticalPositionInput> bodyverticalPosition = null, WorkflowExpression<bodyhorizontalPositionInput> bodyhorizontalPosition = null, WorkflowExpression<string> bodyverticalPositionAdjustment = null, WorkflowExpression<string> bodyhorizontalPositionAdjustment = null, WorkflowExpression<bodymosaicInput> bodymosaic = null, WorkflowExpression<string> bodyrotation = null, WorkflowExpression<bodyfontFamilyInput> bodyfontFamily = null, WorkflowExpression<bodyfontStyleInput> bodyfontStyle = null, WorkflowExpression<string> bodyfontSize = null, WorkflowExpression<string> bodyfontColor = null, WorkflowExpression<string> bodytransparency = null, WorkflowExpression<bodylayerInput> bodylayer = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodymode, nameof(bodymode), required: false);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowExpression.Validate(bodyimageSource, nameof(bodyimageSource), required: false);
            WorkflowExpression.Validate(bodyimageName, nameof(bodyimageName), required: false);
            WorkflowExpression.Validate(bodyimageFile, nameof(bodyimageFile), required: false);
            WorkflowExpression.Validate(bodyimageUrl, nameof(bodyimageUrl), required: false);
            WorkflowExpression.Validate(bodypages, nameof(bodypages), required: false);
            WorkflowExpression.Validate(bodyverticalPosition, nameof(bodyverticalPosition), required: false);
            WorkflowExpression.Validate(bodyhorizontalPosition, nameof(bodyhorizontalPosition), required: false);
            WorkflowExpression.Validate(bodyverticalPositionAdjustment, nameof(bodyverticalPositionAdjustment), required: false);
            WorkflowExpression.Validate(bodyhorizontalPositionAdjustment, nameof(bodyhorizontalPositionAdjustment), required: false);
            WorkflowExpression.Validate(bodymosaic, nameof(bodymosaic), required: false);
            WorkflowExpression.Validate(bodyrotation, nameof(bodyrotation), required: false);
            WorkflowExpression.Validate(bodyfontFamily, nameof(bodyfontFamily), required: false);
            WorkflowExpression.Validate(bodyfontStyle, nameof(bodyfontStyle), required: false);
            WorkflowExpression.Validate(bodyfontSize, nameof(bodyfontSize), required: false);
            WorkflowExpression.Validate(bodyfontColor, nameof(bodyfontColor), required: false);
            WorkflowExpression.Validate(bodytransparency, nameof(bodytransparency), required: false);
            WorkflowExpression.Validate(bodylayer, nameof(bodylayer), required: false);
            return new DeferredBodyAction<WatermarkResponse>(() =>
            {
                var apiCallPath = "/watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodymode != null)
                {
                    body["mode"] = ExpressionConverter.ConvertO(bodymode);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
                    bodypropCount++;
                }

                if (bodyimageSource != null)
                {
                    body["image_source"] = ExpressionConverter.ConvertO(bodyimageSource);
                    bodypropCount++;
                }

                if (bodyimageName != null)
                {
                    body["image_name"] = ExpressionConverter.ConvertO(bodyimageName);
                    bodypropCount++;
                }

                if (bodyimageFile != null)
                {
                    body["image_file"] = ExpressionConverter.ConvertO(bodyimageFile);
                    bodypropCount++;
                }

                if (bodyimageUrl != null)
                {
                    body["image_url"] = ExpressionConverter.ConvertO(bodyimageUrl);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(bodypages);
                    bodypropCount++;
                }

                if (bodyverticalPosition != null)
                {
                    body["vertical_position"] = ExpressionConverter.ConvertO(bodyverticalPosition);
                    bodypropCount++;
                }

                if (bodyhorizontalPosition != null)
                {
                    body["horizontal_position"] = ExpressionConverter.ConvertO(bodyhorizontalPosition);
                    bodypropCount++;
                }

                if (bodyverticalPositionAdjustment != null)
                {
                    body["vertical_position_adjustment"] = ExpressionConverter.ConvertO(bodyverticalPositionAdjustment);
                    bodypropCount++;
                }

                if (bodyhorizontalPositionAdjustment != null)
                {
                    body["horizontal_position_adjustment"] = ExpressionConverter.ConvertO(bodyhorizontalPositionAdjustment);
                    bodypropCount++;
                }

                if (bodymosaic != null)
                {
                    body["mosaic"] = ExpressionConverter.ConvertO(bodymosaic);
                    bodypropCount++;
                }

                if (bodyrotation != null)
                {
                    body["rotation"] = ExpressionConverter.ConvertO(bodyrotation);
                    bodypropCount++;
                }

                if (bodyfontFamily != null)
                {
                    body["font_family"] = ExpressionConverter.ConvertO(bodyfontFamily);
                    bodypropCount++;
                }

                if (bodyfontStyle != null)
                {
                    body["font_style"] = ExpressionConverter.ConvertO(bodyfontStyle);
                    bodypropCount++;
                }

                if (bodyfontSize != null)
                {
                    body["font_size"] = ExpressionConverter.ConvertO(bodyfontSize);
                    bodypropCount++;
                }

                if (bodyfontColor != null)
                {
                    body["font_color"] = ExpressionConverter.ConvertO(bodyfontColor);
                    bodypropCount++;
                }

                if (bodytransparency != null)
                {
                    body["transparency"] = ExpressionConverter.ConvertO(bodytransparency);
                    bodypropCount++;
                }

                if (bodylayer != null)
                {
                    body["layer"] = ExpressionConverter.ConvertO(bodylayer);
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
        [WorkflowExpressionFactory(nameof(__BuildRotate))]
        public IBodyWorkflowAction<RotateResponse> Rotate([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyrotateInput> bodyrotate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RotateResponse> __BuildRotate(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<bodyrotateInput> bodyrotate = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodyrotate, nameof(bodyrotate), required: false);
            return new DeferredBodyAction<RotateResponse>(() =>
            {
                var apiCallPath = "/rotate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyrotate != null)
                {
                    body["rotate"] = ExpressionConverter.ConvertO(bodyrotate);
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
        [WorkflowExpressionFactory(nameof(__BuildPDFOCR))]
        public IBodyWorkflowAction<PDFOCRResponse> PDFOCR([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyocrLanguages = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PDFOCRResponse> __BuildPDFOCR(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<string> bodyocrLanguages = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodyocrLanguages, nameof(bodyocrLanguages), required: false);
            return new DeferredBodyAction<PDFOCRResponse>(() =>
            {
                var apiCallPath = "/pdfocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyocrLanguages != null)
                {
                    body["ocr_languages"] = ExpressionConverter.ConvertO(bodyocrLanguages);
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
        [WorkflowExpressionFactory(nameof(__BuildOfficeToPDF))]
        public IBodyWorkflowAction<OfficeToPDFResponse> OfficeToPDF([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeToPDFResponse> __BuildOfficeToPDF(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            return new DeferredBodyAction<OfficeToPDFResponse>(() =>
            {
                var apiCallPath = "/officetopdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
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