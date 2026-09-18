//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IlovepdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<CompressResponse> Compress([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodycompressionLevelInput> bodycompressionLevel = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodycompressionLevel, nameof(bodycompressionLevel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/compress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodycompressionLevel != null)
                {
                    body["compression_level"] = SourceExpressionConverter.Convert(bodycompressionLevel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CompressResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<SplitResponse> Split([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<bodysplitModeInput> bodysplitMode, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyranges = null, [WorkflowExpression] Func<string> bodyfixedRange = null, [WorkflowExpression] Func<string> bodyremovePages = null, [WorkflowExpression] Func<bodymergeAfterInput> bodymergeAfter = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodysplitMode, nameof(bodysplitMode), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodyranges, nameof(bodyranges), required: false);
            SourceExpression.Validate(bodyfixedRange, nameof(bodyfixedRange), required: false);
            SourceExpression.Validate(bodyremovePages, nameof(bodyremovePages), required: false);
            SourceExpression.Validate(bodymergeAfter, nameof(bodymergeAfter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["split_mode"] = SourceExpressionConverter.Convert(bodysplitMode);
                if (bodyranges != null)
                {
                    body["ranges"] = SourceExpressionConverter.ConvertToken(bodyranges);
                    bodypropCount++;
                }

                if (bodyfixedRange != null)
                {
                    body["fixed_range"] = SourceExpressionConverter.ConvertToken(bodyfixedRange);
                    bodypropCount++;
                }

                if (bodyremovePages != null)
                {
                    body["remove_pages"] = SourceExpressionConverter.ConvertToken(bodyremovePages);
                    bodypropCount++;
                }

                if (bodymergeAfter != null)
                {
                    body["merge_after"] = SourceExpressionConverter.Convert(bodymergeAfter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SplitResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<ProtectResponse> Protect([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/protect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProtectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<PDFtoJPGResponse> PDFtoJPG([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodypdfjpgModeInput> bodypdfjpgMode = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodypdfjpgMode, nameof(bodypdfjpgMode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdftojpg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodypdfjpgMode != null)
                {
                    body["pdfjpg_mode"] = SourceExpressionConverter.Convert(bodypdfjpgMode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFtoJPGResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<ImageToPDFResponse> ImageToPDF([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyorientation = null, [WorkflowExpression] Func<string> bodymargin = null, [WorkflowExpression] Func<bodypagesizeInput> bodypagesize = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodyorientation, nameof(bodyorientation), required: false);
            SourceExpression.Validate(bodymargin, nameof(bodymargin), required: false);
            SourceExpression.Validate(bodypagesize, nameof(bodypagesize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/jpgtoimg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyorientation != null)
                {
                    body["orientation"] = SourceExpressionConverter.ConvertToken(bodyorientation);
                    bodypropCount++;
                }

                if (bodymargin != null)
                {
                    body["margin"] = SourceExpressionConverter.ConvertToken(bodymargin);
                    bodypropCount++;
                }

                if (bodypagesize != null)
                {
                    body["pagesize"] = SourceExpressionConverter.Convert(bodypagesize);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImageToPDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<PDFtoPDFAResponse> PDFtoPDFA([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyconformanceInput> bodyconformance = null, [WorkflowExpression] Func<bodyallowDowngradeInput> bodyallowDowngrade = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodyconformance, nameof(bodyconformance), required: false);
            SourceExpression.Validate(bodyallowDowngrade, nameof(bodyallowDowngrade), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdftopdfa";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyconformance != null)
                {
                    body["conformance"] = SourceExpressionConverter.Convert(bodyconformance);
                    bodypropCount++;
                }

                if (bodyallowDowngrade != null)
                {
                    body["allow_downgrade"] = SourceExpressionConverter.Convert(bodyallowDowngrade);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFtoPDFAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<UnlockResponse> Unlock([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
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

            return new ApiConnectionAction<UnlockResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<AddPageNumberResponse> AddPageNumber([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyfacingPagesInput> bodyfacingPages = null, [WorkflowExpression] Func<bodyfirstCoverInput> bodyfirstCover = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodystartingNumber = null, [WorkflowExpression] Func<bodyverticalPositionInput> bodyverticalPosition = null, [WorkflowExpression] Func<bodyhorizontalPositionInput> bodyhorizontalPosition = null, [WorkflowExpression] Func<string> bodyverticalPositionAdjustment = null, [WorkflowExpression] Func<string> bodyhorizontalPositionAdjustment = null, [WorkflowExpression] Func<bodyfontFamilyInput> bodyfontFamily = null, [WorkflowExpression] Func<string> bodyfontSize = null, [WorkflowExpression] Func<string> bodyfontColor = null, [WorkflowExpression] Func<string> bodytext = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodyfacingPages, nameof(bodyfacingPages), required: false);
            SourceExpression.Validate(bodyfirstCover, nameof(bodyfirstCover), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodystartingNumber, nameof(bodystartingNumber), required: false);
            SourceExpression.Validate(bodyverticalPosition, nameof(bodyverticalPosition), required: false);
            SourceExpression.Validate(bodyhorizontalPosition, nameof(bodyhorizontalPosition), required: false);
            SourceExpression.Validate(bodyverticalPositionAdjustment, nameof(bodyverticalPositionAdjustment), required: false);
            SourceExpression.Validate(bodyhorizontalPositionAdjustment, nameof(bodyhorizontalPositionAdjustment), required: false);
            SourceExpression.Validate(bodyfontFamily, nameof(bodyfontFamily), required: false);
            SourceExpression.Validate(bodyfontSize, nameof(bodyfontSize), required: false);
            SourceExpression.Validate(bodyfontColor, nameof(bodyfontColor), required: false);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pagenumber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyfacingPages != null)
                {
                    body["facing_pages"] = SourceExpressionConverter.Convert(bodyfacingPages);
                    bodypropCount++;
                }

                if (bodyfirstCover != null)
                {
                    body["first_cover"] = SourceExpressionConverter.Convert(bodyfirstCover);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodystartingNumber != null)
                {
                    body["starting_number"] = SourceExpressionConverter.ConvertToken(bodystartingNumber);
                    bodypropCount++;
                }

                if (bodyverticalPosition != null)
                {
                    body["vertical_position"] = SourceExpressionConverter.Convert(bodyverticalPosition);
                    bodypropCount++;
                }

                if (bodyhorizontalPosition != null)
                {
                    body["horizontal_position"] = SourceExpressionConverter.Convert(bodyhorizontalPosition);
                    bodypropCount++;
                }

                if (bodyverticalPositionAdjustment != null)
                {
                    body["vertical_position_adjustment"] = SourceExpressionConverter.ConvertToken(bodyverticalPositionAdjustment);
                    bodypropCount++;
                }

                if (bodyhorizontalPositionAdjustment != null)
                {
                    body["horizontal_position_adjustment"] = SourceExpressionConverter.ConvertToken(bodyhorizontalPositionAdjustment);
                    bodypropCount++;
                }

                if (bodyfontFamily != null)
                {
                    body["font_family"] = SourceExpressionConverter.Convert(bodyfontFamily);
                    bodypropCount++;
                }

                if (bodyfontSize != null)
                {
                    body["font_size"] = SourceExpressionConverter.ConvertToken(bodyfontSize);
                    bodypropCount++;
                }

                if (bodyfontColor != null)
                {
                    body["font_color"] = SourceExpressionConverter.ConvertToken(bodyfontColor);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddPageNumberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<MergeResponse> Merge([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyfileSource2Input> bodyfileSource2 = null, [WorkflowExpression] Func<string> bodyfileName2 = null, [WorkflowExpression] Func<string> bodyfile2 = null, [WorkflowExpression] Func<string> bodyfileUrl2 = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodyfileSource2, nameof(bodyfileSource2), required: false);
            SourceExpression.Validate(bodyfileName2, nameof(bodyfileName2), required: false);
            SourceExpression.Validate(bodyfile2, nameof(bodyfile2), required: false);
            SourceExpression.Validate(bodyfileUrl2, nameof(bodyfileUrl2), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyfileSource2 != null)
                {
                    body["file_source2"] = SourceExpressionConverter.Convert(bodyfileSource2);
                    bodypropCount++;
                }

                if (bodyfileName2 != null)
                {
                    body["file_name2"] = SourceExpressionConverter.ConvertToken(bodyfileName2);
                    bodypropCount++;
                }

                if (bodyfile2 != null)
                {
                    body["file2"] = SourceExpressionConverter.ConvertToken(bodyfile2);
                    bodypropCount++;
                }

                if (bodyfileUrl2 != null)
                {
                    body["file_url2"] = SourceExpressionConverter.ConvertToken(bodyfileUrl2);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MergeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<WatermarkResponse> Watermark([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodymodeInput> bodymode = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyimageSource = null, [WorkflowExpression] Func<string> bodyimageName = null, [WorkflowExpression] Func<string> bodyimageFile = null, [WorkflowExpression] Func<string> bodyimageUrl = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<bodyverticalPositionInput> bodyverticalPosition = null, [WorkflowExpression] Func<bodyhorizontalPositionInput> bodyhorizontalPosition = null, [WorkflowExpression] Func<string> bodyverticalPositionAdjustment = null, [WorkflowExpression] Func<string> bodyhorizontalPositionAdjustment = null, [WorkflowExpression] Func<bodymosaicInput> bodymosaic = null, [WorkflowExpression] Func<string> bodyrotation = null, [WorkflowExpression] Func<bodyfontFamilyInput> bodyfontFamily = null, [WorkflowExpression] Func<bodyfontStyleInput> bodyfontStyle = null, [WorkflowExpression] Func<string> bodyfontSize = null, [WorkflowExpression] Func<string> bodyfontColor = null, [WorkflowExpression] Func<string> bodytransparency = null, [WorkflowExpression] Func<bodylayerInput> bodylayer = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodymode, nameof(bodymode), required: false);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyimageSource, nameof(bodyimageSource), required: false);
            SourceExpression.Validate(bodyimageName, nameof(bodyimageName), required: false);
            SourceExpression.Validate(bodyimageFile, nameof(bodyimageFile), required: false);
            SourceExpression.Validate(bodyimageUrl, nameof(bodyimageUrl), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodyverticalPosition, nameof(bodyverticalPosition), required: false);
            SourceExpression.Validate(bodyhorizontalPosition, nameof(bodyhorizontalPosition), required: false);
            SourceExpression.Validate(bodyverticalPositionAdjustment, nameof(bodyverticalPositionAdjustment), required: false);
            SourceExpression.Validate(bodyhorizontalPositionAdjustment, nameof(bodyhorizontalPositionAdjustment), required: false);
            SourceExpression.Validate(bodymosaic, nameof(bodymosaic), required: false);
            SourceExpression.Validate(bodyrotation, nameof(bodyrotation), required: false);
            SourceExpression.Validate(bodyfontFamily, nameof(bodyfontFamily), required: false);
            SourceExpression.Validate(bodyfontStyle, nameof(bodyfontStyle), required: false);
            SourceExpression.Validate(bodyfontSize, nameof(bodyfontSize), required: false);
            SourceExpression.Validate(bodyfontColor, nameof(bodyfontColor), required: false);
            SourceExpression.Validate(bodytransparency, nameof(bodytransparency), required: false);
            SourceExpression.Validate(bodylayer, nameof(bodylayer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodymode != null)
                {
                    body["mode"] = SourceExpressionConverter.Convert(bodymode);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyimageSource != null)
                {
                    body["image_source"] = SourceExpressionConverter.ConvertToken(bodyimageSource);
                    bodypropCount++;
                }

                if (bodyimageName != null)
                {
                    body["image_name"] = SourceExpressionConverter.ConvertToken(bodyimageName);
                    bodypropCount++;
                }

                if (bodyimageFile != null)
                {
                    body["image_file"] = SourceExpressionConverter.ConvertToken(bodyimageFile);
                    bodypropCount++;
                }

                if (bodyimageUrl != null)
                {
                    body["image_url"] = SourceExpressionConverter.ConvertToken(bodyimageUrl);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodyverticalPosition != null)
                {
                    body["vertical_position"] = SourceExpressionConverter.Convert(bodyverticalPosition);
                    bodypropCount++;
                }

                if (bodyhorizontalPosition != null)
                {
                    body["horizontal_position"] = SourceExpressionConverter.Convert(bodyhorizontalPosition);
                    bodypropCount++;
                }

                if (bodyverticalPositionAdjustment != null)
                {
                    body["vertical_position_adjustment"] = SourceExpressionConverter.ConvertToken(bodyverticalPositionAdjustment);
                    bodypropCount++;
                }

                if (bodyhorizontalPositionAdjustment != null)
                {
                    body["horizontal_position_adjustment"] = SourceExpressionConverter.ConvertToken(bodyhorizontalPositionAdjustment);
                    bodypropCount++;
                }

                if (bodymosaic != null)
                {
                    body["mosaic"] = SourceExpressionConverter.Convert(bodymosaic);
                    bodypropCount++;
                }

                if (bodyrotation != null)
                {
                    body["rotation"] = SourceExpressionConverter.ConvertToken(bodyrotation);
                    bodypropCount++;
                }

                if (bodyfontFamily != null)
                {
                    body["font_family"] = SourceExpressionConverter.Convert(bodyfontFamily);
                    bodypropCount++;
                }

                if (bodyfontStyle != null)
                {
                    body["font_style"] = SourceExpressionConverter.Convert(bodyfontStyle);
                    bodypropCount++;
                }

                if (bodyfontSize != null)
                {
                    body["font_size"] = SourceExpressionConverter.ConvertToken(bodyfontSize);
                    bodypropCount++;
                }

                if (bodyfontColor != null)
                {
                    body["font_color"] = SourceExpressionConverter.ConvertToken(bodyfontColor);
                    bodypropCount++;
                }

                if (bodytransparency != null)
                {
                    body["transparency"] = SourceExpressionConverter.ConvertToken(bodytransparency);
                    bodypropCount++;
                }

                if (bodylayer != null)
                {
                    body["layer"] = SourceExpressionConverter.Convert(bodylayer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WatermarkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<RotateResponse> Rotate([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyrotateInput> bodyrotate = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodyrotate, nameof(bodyrotate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rotate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyrotate != null)
                {
                    body["rotate"] = SourceExpressionConverter.Convert(bodyrotate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RotateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<PDFOCRResponse> PDFOCR([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyocrLanguages = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodyocrLanguages, nameof(bodyocrLanguages), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdfocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodyocrLanguages != null)
                {
                    body["ocr_languages"] = SourceExpressionConverter.ConvertToken(bodyocrLanguages);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFOCRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<OfficeToPDFResponse> OfficeToPDF([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/officetopdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OfficeToPDFResponse>(BuildSourceInput);
        }
    }

    public class IlovepdfTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompressResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public enum bodyfileSourceInput
    {
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "url")]
        Url
    }

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

    public enum bodyfacingPagesInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum bodyfirstCoverInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum bodyverticalPositionInput
    {
        [EnumMember(Value = "bottom")]
        Bottom,
        [EnumMember(Value = "middle")]
        Middle,
        [EnumMember(Value = "top")]
        Top
    }

    public enum bodyhorizontalPositionInput
    {
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "right")]
        Right
    }

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

    public enum bodymodeInput
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "image")]
        Image
    }

    public enum bodymosaicInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum bodyfontStyleInput
    {
        Bold,
        Italic
    }

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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdf;

    public partial class WorkflowManagedActions
    {
        public IlovepdfActions Ilovepdf(string connectionId) => new IlovepdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IlovepdfTriggers Ilovepdf(string connectionId) => new IlovepdfTriggers(connectionId);
    }
}