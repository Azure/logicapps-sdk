//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ilovepdfv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<CompressResponse> Compress(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodycompressionLevelInput>> bodycompressionLevel = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<SplitResponse> Split(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<bodysplitModeInput>> bodysplitMode, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyranges = null, Expression<Func<string>> bodyfixedRange = null, Expression<Func<string>> bodyremovePages = null, Expression<Func<bodymergeAfterInput>> bodymergeAfter = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<ProtectResponse> Protect(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodypassword, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<PDFtoJPGResponse> PDFtoJPG(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodypdfjpgModeInput>> bodypdfjpgMode = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<ImageToPDFResponse> ImageToPDF(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyorientation = null, Expression<Func<string>> bodymargin = null, Expression<Func<bodypagesizeInput>> bodypagesize = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<PDFtoPDFAResponse> PDFtoPDFA(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyconformanceInput>> bodyconformance = null, Expression<Func<bodyallowDowngradeInput>> bodyallowDowngrade = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<UnlockResponse> Unlock(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodypassword = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<AddPageNumberResponse> AddPageNumber(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyfacingPagesInput>> bodyfacingPages = null, Expression<Func<bodyfirstCoverInput>> bodyfirstCover = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodystartingNumber = null, Expression<Func<bodyverticalPositionInput>> bodyverticalPosition = null, Expression<Func<bodyhorizontalPositionInput>> bodyhorizontalPosition = null, Expression<Func<string>> bodyverticalPositionAdjustment = null, Expression<Func<string>> bodyhorizontalPositionAdjustment = null, Expression<Func<bodyfontFamilyInput>> bodyfontFamily = null, Expression<Func<string>> bodyfontSize = null, Expression<Func<string>> bodyfontColor = null, Expression<Func<string>> bodytext = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<MergeResponse> Merge(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyfileSource2Input>> bodyfileSource2 = null, Expression<Func<string>> bodyfileName2 = null, Expression<Func<string>> bodyfile2 = null, Expression<Func<string>> bodyfileUrl2 = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<WatermarkResponse> Watermark(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodymodeInput>> bodymode = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyimageSource = null, Expression<Func<string>> bodyimageName = null, Expression<Func<string>> bodyimageFile = null, Expression<Func<string>> bodyimageUrl = null, Expression<Func<string>> bodypages = null, Expression<Func<bodyverticalPositionInput>> bodyverticalPosition = null, Expression<Func<bodyhorizontalPositionInput>> bodyhorizontalPosition = null, Expression<Func<string>> bodyverticalPositionAdjustment = null, Expression<Func<string>> bodyhorizontalPositionAdjustment = null, Expression<Func<bodymosaicInput>> bodymosaic = null, Expression<Func<string>> bodyrotation = null, Expression<Func<bodyfontFamilyInput>> bodyfontFamily = null, Expression<Func<bodyfontStyleInput>> bodyfontStyle = null, Expression<Func<string>> bodyfontSize = null, Expression<Func<string>> bodyfontColor = null, Expression<Func<string>> bodytransparency = null, Expression<Func<bodylayerInput>> bodylayer = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<RotateResponse> Rotate(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyrotateInput>> bodyrotate = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<PDFOCRResponse> PDFOCR(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyocrLanguages = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<OfficeToPDFResponse> OfficeToPDF(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null)
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