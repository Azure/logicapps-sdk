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
        public IBodyWorkflowAction<object> Compress([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodycompressionLevelInput> bodycompressionLevel = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> Split([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<bodysplitModeInput> bodysplitMode, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyranges = null, [WorkflowExpression] Func<string> bodyfixedRange = null, [WorkflowExpression] Func<string> bodyremovePages = null, [WorkflowExpression] Func<bodymergeAfterInput> bodymergeAfter = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> Protect([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> PDFtoJPG([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodypdfjpgModeInput> bodypdfjpgMode = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> ImageToPDF([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyorientation = null, [WorkflowExpression] Func<string> bodymargin = null, [WorkflowExpression] Func<bodypagesizeInput> bodypagesize = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> PDFtoPDFA([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyconformanceInput> bodyconformance = null, [WorkflowExpression] Func<bodyallowDowngradeInput> bodyallowDowngrade = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> Unlock([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> AddPageNumber([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyfacingPagesInput> bodyfacingPages = null, [WorkflowExpression] Func<bodyfirstCoverInput> bodyfirstCover = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodystartingNumber = null, [WorkflowExpression] Func<bodyverticalPositionInput> bodyverticalPosition = null, [WorkflowExpression] Func<bodyhorizontalPositionInput> bodyhorizontalPosition = null, [WorkflowExpression] Func<string> bodyverticalPositionAdjustment = null, [WorkflowExpression] Func<string> bodyhorizontalPositionAdjustment = null, [WorkflowExpression] Func<bodyfontFamilyInput> bodyfontFamily = null, [WorkflowExpression] Func<string> bodyfontSize = null, [WorkflowExpression] Func<string> bodyfontColor = null, [WorkflowExpression] Func<string> bodytext = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> Merge([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyfileSource2Input> bodyfileSource2 = null, [WorkflowExpression] Func<string> bodyfileName2 = null, [WorkflowExpression] Func<string> bodyfile2 = null, [WorkflowExpression] Func<string> bodyfileUrl2 = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> Watermark([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodymodeInput> bodymode = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyimageSource = null, [WorkflowExpression] Func<string> bodyimageName = null, [WorkflowExpression] Func<string> bodyimageFile = null, [WorkflowExpression] Func<string> bodyimageUrl = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<bodyverticalPositionInput> bodyverticalPosition = null, [WorkflowExpression] Func<bodyhorizontalPositionInput> bodyhorizontalPosition = null, [WorkflowExpression] Func<string> bodyverticalPositionAdjustment = null, [WorkflowExpression] Func<string> bodyhorizontalPositionAdjustment = null, [WorkflowExpression] Func<bodymosaicInput> bodymosaic = null, [WorkflowExpression] Func<string> bodyrotation = null, [WorkflowExpression] Func<bodyfontFamilyInput> bodyfontFamily = null, [WorkflowExpression] Func<bodyfontStyleInput> bodyfontStyle = null, [WorkflowExpression] Func<string> bodyfontSize = null, [WorkflowExpression] Func<string> bodyfontColor = null, [WorkflowExpression] Func<string> bodytransparency = null, [WorkflowExpression] Func<bodylayerInput> bodylayer = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> Rotate([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<bodyrotateInput> bodyrotate = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> PDFOCR([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyocrLanguages = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> OfficeToPDF([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
        {
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
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> DetectForms([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/detectforms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> Summarize([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodyoutputFormat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/summarize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                if (bodyoutputFormat != null)
                {
                    body["output_format"] = SourceExpressionConverter.ConvertToken(bodyoutputFormat);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> Translate([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodylanguageOutput = null, [WorkflowExpression] Func<string> bodytranslateMode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodylanguageOutput != null)
                {
                    body["language_output"] = SourceExpressionConverter.ConvertToken(bodylanguageOutput);
                    bodypropCount++;
                }

                if (bodytranslateMode != null)
                {
                    body["translate_mode"] = SourceExpressionConverter.ConvertToken(bodytranslateMode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> SplitSmart([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/splitsmart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object> PDFMarkdown([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyfileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdfmarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
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

            return new ApiConnectionAction<object>(BuildSourceInput);
        }
    }

    public class Ilovepdfv2Triggers([ConnectionName] string connectionId)
    {
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

    public enum bodypdfjpgModeInput
    {
        [EnumMember(Value = "pages")]
        Pages,
        [EnumMember(Value = "extract")]
        Extract
    }

    public enum bodypagesizeInput
    {
        [EnumMember(Value = "fit")]
        Fit,
        A4,
        [EnumMember(Value = "letter")]
        Letter
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

    public enum bodyfileSource2Input
    {
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "url")]
        Url
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