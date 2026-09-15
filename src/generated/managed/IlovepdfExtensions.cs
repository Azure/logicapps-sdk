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
        public IBodyWorkflowAction<CompressResponse> Compress(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodycompressionLevelInput>> bodycompressionLevel = null)
        {
            var apiCallPath = "/compress";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodycompressionLevel != null)
            {
                body["compression_level"] = CSharpExpressionConverter.Convert(bodycompressionLevel);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CompressResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<SplitResponse> Split(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<bodysplitModeInput>> bodysplitMode, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyranges = null, Expression<Func<string>> bodyfixedRange = null, Expression<Func<string>> bodyremovePages = null, Expression<Func<bodymergeAfterInput>> bodymergeAfter = null)
        {
            var apiCallPath = "/split";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            bodypropCount++;
            body["split_mode"] = CSharpExpressionConverter.Convert(bodysplitMode);
            if (bodyranges != null)
            {
                body["ranges"] = CSharpExpressionConverter.ConvertToken(bodyranges);
                bodypropCount++;
            }

            if (bodyfixedRange != null)
            {
                body["fixed_range"] = CSharpExpressionConverter.ConvertToken(bodyfixedRange);
                bodypropCount++;
            }

            if (bodyremovePages != null)
            {
                body["remove_pages"] = CSharpExpressionConverter.ConvertToken(bodyremovePages);
                bodypropCount++;
            }

            if (bodymergeAfter != null)
            {
                body["merge_after"] = CSharpExpressionConverter.Convert(bodymergeAfter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SplitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<ProtectResponse> Protect(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodypassword, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = "/protect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            bodypropCount++;
            body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProtectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<PDFtoJPGResponse> PDFtoJPG(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodypdfjpgModeInput>> bodypdfjpgMode = null)
        {
            var apiCallPath = "/pdftojpg";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypdfjpgMode != null)
            {
                body["pdfjpg_mode"] = CSharpExpressionConverter.Convert(bodypdfjpgMode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFtoJPGResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<ImageToPDFResponse> ImageToPDF(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyorientation = null, Expression<Func<string>> bodymargin = null, Expression<Func<bodypagesizeInput>> bodypagesize = null)
        {
            var apiCallPath = "/jpgtoimg";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodyorientation != null)
            {
                body["orientation"] = CSharpExpressionConverter.ConvertToken(bodyorientation);
                bodypropCount++;
            }

            if (bodymargin != null)
            {
                body["margin"] = CSharpExpressionConverter.ConvertToken(bodymargin);
                bodypropCount++;
            }

            if (bodypagesize != null)
            {
                body["pagesize"] = CSharpExpressionConverter.Convert(bodypagesize);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ImageToPDFResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<PDFtoPDFAResponse> PDFtoPDFA(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyconformanceInput>> bodyconformance = null, Expression<Func<bodyallowDowngradeInput>> bodyallowDowngrade = null)
        {
            var apiCallPath = "/pdftopdfa";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodyconformance != null)
            {
                body["conformance"] = CSharpExpressionConverter.Convert(bodyconformance);
                bodypropCount++;
            }

            if (bodyallowDowngrade != null)
            {
                body["allow_downgrade"] = CSharpExpressionConverter.Convert(bodyallowDowngrade);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFtoPDFAResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<UnlockResponse> Unlock(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodypassword = null)
        {
            var apiCallPath = "/unlock";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UnlockResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<AddPageNumberResponse> AddPageNumber(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyfacingPagesInput>> bodyfacingPages = null, Expression<Func<bodyfirstCoverInput>> bodyfirstCover = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodystartingNumber = null, Expression<Func<bodyverticalPositionInput>> bodyverticalPosition = null, Expression<Func<bodyhorizontalPositionInput>> bodyhorizontalPosition = null, Expression<Func<string>> bodyverticalPositionAdjustment = null, Expression<Func<string>> bodyhorizontalPositionAdjustment = null, Expression<Func<bodyfontFamilyInput>> bodyfontFamily = null, Expression<Func<string>> bodyfontSize = null, Expression<Func<string>> bodyfontColor = null, Expression<Func<string>> bodytext = null)
        {
            var apiCallPath = "/pagenumber";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodyfacingPages != null)
            {
                body["facing_pages"] = CSharpExpressionConverter.Convert(bodyfacingPages);
                bodypropCount++;
            }

            if (bodyfirstCover != null)
            {
                body["first_cover"] = CSharpExpressionConverter.Convert(bodyfirstCover);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = CSharpExpressionConverter.ConvertToken(bodypages);
                bodypropCount++;
            }

            if (bodystartingNumber != null)
            {
                body["starting_number"] = CSharpExpressionConverter.ConvertToken(bodystartingNumber);
                bodypropCount++;
            }

            if (bodyverticalPosition != null)
            {
                body["vertical_position"] = CSharpExpressionConverter.Convert(bodyverticalPosition);
                bodypropCount++;
            }

            if (bodyhorizontalPosition != null)
            {
                body["horizontal_position"] = CSharpExpressionConverter.Convert(bodyhorizontalPosition);
                bodypropCount++;
            }

            if (bodyverticalPositionAdjustment != null)
            {
                body["vertical_position_adjustment"] = CSharpExpressionConverter.ConvertToken(bodyverticalPositionAdjustment);
                bodypropCount++;
            }

            if (bodyhorizontalPositionAdjustment != null)
            {
                body["horizontal_position_adjustment"] = CSharpExpressionConverter.ConvertToken(bodyhorizontalPositionAdjustment);
                bodypropCount++;
            }

            if (bodyfontFamily != null)
            {
                body["font_family"] = CSharpExpressionConverter.Convert(bodyfontFamily);
                bodypropCount++;
            }

            if (bodyfontSize != null)
            {
                body["font_size"] = CSharpExpressionConverter.ConvertToken(bodyfontSize);
                bodypropCount++;
            }

            if (bodyfontColor != null)
            {
                body["font_color"] = CSharpExpressionConverter.ConvertToken(bodyfontColor);
                bodypropCount++;
            }

            if (bodytext != null)
            {
                body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddPageNumberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<MergeResponse> Merge(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyfileSource2Input>> bodyfileSource2 = null, Expression<Func<string>> bodyfileName2 = null, Expression<Func<string>> bodyfile2 = null, Expression<Func<string>> bodyfileUrl2 = null)
        {
            var apiCallPath = "/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodyfileSource2 != null)
            {
                body["file_source2"] = CSharpExpressionConverter.Convert(bodyfileSource2);
                bodypropCount++;
            }

            if (bodyfileName2 != null)
            {
                body["file_name2"] = CSharpExpressionConverter.ConvertToken(bodyfileName2);
                bodypropCount++;
            }

            if (bodyfile2 != null)
            {
                body["file2"] = CSharpExpressionConverter.ConvertToken(bodyfile2);
                bodypropCount++;
            }

            if (bodyfileUrl2 != null)
            {
                body["file_url2"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl2);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<WatermarkResponse> Watermark(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodymodeInput>> bodymode = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyimageSource = null, Expression<Func<string>> bodyimageName = null, Expression<Func<string>> bodyimageFile = null, Expression<Func<string>> bodyimageUrl = null, Expression<Func<string>> bodypages = null, Expression<Func<bodyverticalPositionInput>> bodyverticalPosition = null, Expression<Func<bodyhorizontalPositionInput>> bodyhorizontalPosition = null, Expression<Func<string>> bodyverticalPositionAdjustment = null, Expression<Func<string>> bodyhorizontalPositionAdjustment = null, Expression<Func<bodymosaicInput>> bodymosaic = null, Expression<Func<string>> bodyrotation = null, Expression<Func<bodyfontFamilyInput>> bodyfontFamily = null, Expression<Func<bodyfontStyleInput>> bodyfontStyle = null, Expression<Func<string>> bodyfontSize = null, Expression<Func<string>> bodyfontColor = null, Expression<Func<string>> bodytransparency = null, Expression<Func<bodylayerInput>> bodylayer = null)
        {
            var apiCallPath = "/watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodymode != null)
            {
                body["mode"] = CSharpExpressionConverter.Convert(bodymode);
                bodypropCount++;
            }

            if (bodytext != null)
            {
                body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
            }

            if (bodyimageSource != null)
            {
                body["image_source"] = CSharpExpressionConverter.ConvertToken(bodyimageSource);
                bodypropCount++;
            }

            if (bodyimageName != null)
            {
                body["image_name"] = CSharpExpressionConverter.ConvertToken(bodyimageName);
                bodypropCount++;
            }

            if (bodyimageFile != null)
            {
                body["image_file"] = CSharpExpressionConverter.ConvertToken(bodyimageFile);
                bodypropCount++;
            }

            if (bodyimageUrl != null)
            {
                body["image_url"] = CSharpExpressionConverter.ConvertToken(bodyimageUrl);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = CSharpExpressionConverter.ConvertToken(bodypages);
                bodypropCount++;
            }

            if (bodyverticalPosition != null)
            {
                body["vertical_position"] = CSharpExpressionConverter.Convert(bodyverticalPosition);
                bodypropCount++;
            }

            if (bodyhorizontalPosition != null)
            {
                body["horizontal_position"] = CSharpExpressionConverter.Convert(bodyhorizontalPosition);
                bodypropCount++;
            }

            if (bodyverticalPositionAdjustment != null)
            {
                body["vertical_position_adjustment"] = CSharpExpressionConverter.ConvertToken(bodyverticalPositionAdjustment);
                bodypropCount++;
            }

            if (bodyhorizontalPositionAdjustment != null)
            {
                body["horizontal_position_adjustment"] = CSharpExpressionConverter.ConvertToken(bodyhorizontalPositionAdjustment);
                bodypropCount++;
            }

            if (bodymosaic != null)
            {
                body["mosaic"] = CSharpExpressionConverter.Convert(bodymosaic);
                bodypropCount++;
            }

            if (bodyrotation != null)
            {
                body["rotation"] = CSharpExpressionConverter.ConvertToken(bodyrotation);
                bodypropCount++;
            }

            if (bodyfontFamily != null)
            {
                body["font_family"] = CSharpExpressionConverter.Convert(bodyfontFamily);
                bodypropCount++;
            }

            if (bodyfontStyle != null)
            {
                body["font_style"] = CSharpExpressionConverter.Convert(bodyfontStyle);
                bodypropCount++;
            }

            if (bodyfontSize != null)
            {
                body["font_size"] = CSharpExpressionConverter.ConvertToken(bodyfontSize);
                bodypropCount++;
            }

            if (bodyfontColor != null)
            {
                body["font_color"] = CSharpExpressionConverter.ConvertToken(bodyfontColor);
                bodypropCount++;
            }

            if (bodytransparency != null)
            {
                body["transparency"] = CSharpExpressionConverter.ConvertToken(bodytransparency);
                bodypropCount++;
            }

            if (bodylayer != null)
            {
                body["layer"] = CSharpExpressionConverter.Convert(bodylayer);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WatermarkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<RotateResponse> Rotate(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyrotateInput>> bodyrotate = null)
        {
            var apiCallPath = "/rotate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodyrotate != null)
            {
                body["rotate"] = CSharpExpressionConverter.Convert(bodyrotate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RotateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<PDFOCRResponse> PDFOCR(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyocrLanguages = null)
        {
            var apiCallPath = "/pdfocr";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodyocrLanguages != null)
            {
                body["ocr_languages"] = CSharpExpressionConverter.ConvertToken(bodyocrLanguages);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFOCRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdf")]
        public IBodyWorkflowAction<OfficeToPDFResponse> OfficeToPDF(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = "/officetopdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
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