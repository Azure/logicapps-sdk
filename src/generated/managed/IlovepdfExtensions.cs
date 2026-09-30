//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdf
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IlovepdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<CompressResponse> Compress([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodycompressionLevelInput> bodycompressionLevel = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<SplitResponse> Split([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<bodysplitModeInput> bodysplitMode, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyranges = null, [WorkflowExpression] Func<string> bodyfixedRange = null, [WorkflowExpression] Func<string> bodyremovePages = null, [WorkflowExpression] Func<bodymergeAfterInput> bodymergeAfter = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<ProtectResponse> Protect([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<PDFtoJPGResponse> PDFtoJPG([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodypdfjpgModeInput> bodypdfjpgMode = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<ImageToPDFResponse> ImageToPDF([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyorientation = null, [WorkflowExpression] Func<string> bodymargin = null, [WorkflowExpression] Func<bodypagesizeInput> bodypagesize = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<PDFtoPDFAResponse> PDFtoPDFA([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyconformanceInput> bodyconformance = null, [WorkflowExpression] Func<bodyallowDowngradeInput> bodyallowDowngrade = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<UnlockResponse> Unlock([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodypassword = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<AddPageNumberResponse> AddPageNumber([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyfacingPagesInput> bodyfacingPages = null, [WorkflowExpression] Func<bodyfirstCoverInput> bodyfirstCover = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodystartingNumber = null, [WorkflowExpression] Func<bodyverticalPositionInput> bodyverticalPosition = null, [WorkflowExpression] Func<bodyhorizontalPositionInput> bodyhorizontalPosition = null, [WorkflowExpression] Func<string> bodyverticalPositionAdjustment = null, [WorkflowExpression] Func<string> bodyhorizontalPositionAdjustment = null, [WorkflowExpression] Func<bodyfontFamilyInput> bodyfontFamily = null, [WorkflowExpression] Func<string> bodyfontSize = null, [WorkflowExpression] Func<string> bodyfontColor = null, [WorkflowExpression] Func<string> bodytext = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<MergeResponse> Merge([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyfileSource2Input> bodyfileSource2 = null, [WorkflowExpression] Func<string> bodyfileName2 = null, [WorkflowExpression] Func<string> bodyfile2 = null, [WorkflowExpression] Func<string> bodyfileUrl2 = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<WatermarkResponse> Watermark([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodymodeInput> bodymode = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyimageSource = null, [WorkflowExpression] Func<string> bodyimageName = null, [WorkflowExpression] Func<string> bodyimageFile = null, [WorkflowExpression] Func<string> bodyimageUrl = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<bodyverticalPositionInput> bodyverticalPosition = null, [WorkflowExpression] Func<bodyhorizontalPositionInput> bodyhorizontalPosition = null, [WorkflowExpression] Func<string> bodyverticalPositionAdjustment = null, [WorkflowExpression] Func<string> bodyhorizontalPositionAdjustment = null, [WorkflowExpression] Func<bodymosaicInput> bodymosaic = null, [WorkflowExpression] Func<string> bodyrotation = null, [WorkflowExpression] Func<bodyfontFamilyInput> bodyfontFamily = null, [WorkflowExpression] Func<bodyfontStyleInput> bodyfontStyle = null, [WorkflowExpression] Func<string> bodyfontSize = null, [WorkflowExpression] Func<string> bodyfontColor = null, [WorkflowExpression] Func<string> bodytransparency = null, [WorkflowExpression] Func<bodylayerInput> bodylayer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<RotateResponse> Rotate([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyrotateInput> bodyrotate = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<PDFOCRResponse> PDFOCR([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyocrLanguages = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<OfficeToPDFResponse> OfficeToPDF([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
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