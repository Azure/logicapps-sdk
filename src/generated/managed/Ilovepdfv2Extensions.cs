//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ilovepdfv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Compress(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodycompressionLevelInput>> bodycompressionLevel = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodycompressionLevel = WorkflowExpression.Compile(bodycompressionLevel, nameof(bodycompressionLevel), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Split(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<bodysplitModeInput>> bodysplitMode, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyranges = null, Expression<Func<string>> bodyfixedRange = null, Expression<Func<string>> bodyremovePages = null, Expression<Func<bodymergeAfterInput>> bodymergeAfter = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodysplitMode = WorkflowExpression.Compile(bodysplitMode, nameof(bodysplitMode), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyranges = WorkflowExpression.Compile(bodyranges, nameof(bodyranges), required: false);
            var __workflow_bodyfixedRange = WorkflowExpression.Compile(bodyfixedRange, nameof(bodyfixedRange), required: false);
            var __workflow_bodyremovePages = WorkflowExpression.Compile(bodyremovePages, nameof(bodyremovePages), required: false);
            var __workflow_bodymergeAfter = WorkflowExpression.Compile(bodymergeAfter, nameof(bodymergeAfter), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Protect(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodypassword, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> PDFtoJPG(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodypdfjpgModeInput>> bodypdfjpgMode = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodypdfjpgMode = WorkflowExpression.Compile(bodypdfjpgMode, nameof(bodypdfjpgMode), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> ImageToPDF(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyorientation = null, Expression<Func<string>> bodymargin = null, Expression<Func<bodypagesizeInput>> bodypagesize = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyorientation = WorkflowExpression.Compile(bodyorientation, nameof(bodyorientation), required: false);
            var __workflow_bodymargin = WorkflowExpression.Compile(bodymargin, nameof(bodymargin), required: false);
            var __workflow_bodypagesize = WorkflowExpression.Compile(bodypagesize, nameof(bodypagesize), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> PDFtoPDFA(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyconformanceInput>> bodyconformance = null, Expression<Func<bodyallowDowngradeInput>> bodyallowDowngrade = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyconformance = WorkflowExpression.Compile(bodyconformance, nameof(bodyconformance), required: false);
            var __workflow_bodyallowDowngrade = WorkflowExpression.Compile(bodyallowDowngrade, nameof(bodyallowDowngrade), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Unlock(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodypassword = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> AddPageNumber(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyfacingPagesInput>> bodyfacingPages = null, Expression<Func<bodyfirstCoverInput>> bodyfirstCover = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodystartingNumber = null, Expression<Func<bodyverticalPositionInput>> bodyverticalPosition = null, Expression<Func<bodyhorizontalPositionInput>> bodyhorizontalPosition = null, Expression<Func<string>> bodyverticalPositionAdjustment = null, Expression<Func<string>> bodyhorizontalPositionAdjustment = null, Expression<Func<bodyfontFamilyInput>> bodyfontFamily = null, Expression<Func<string>> bodyfontSize = null, Expression<Func<string>> bodyfontColor = null, Expression<Func<string>> bodytext = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyfacingPages = WorkflowExpression.Compile(bodyfacingPages, nameof(bodyfacingPages), required: false);
            var __workflow_bodyfirstCover = WorkflowExpression.Compile(bodyfirstCover, nameof(bodyfirstCover), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodystartingNumber = WorkflowExpression.Compile(bodystartingNumber, nameof(bodystartingNumber), required: false);
            var __workflow_bodyverticalPosition = WorkflowExpression.Compile(bodyverticalPosition, nameof(bodyverticalPosition), required: false);
            var __workflow_bodyhorizontalPosition = WorkflowExpression.Compile(bodyhorizontalPosition, nameof(bodyhorizontalPosition), required: false);
            var __workflow_bodyverticalPositionAdjustment = WorkflowExpression.Compile(bodyverticalPositionAdjustment, nameof(bodyverticalPositionAdjustment), required: false);
            var __workflow_bodyhorizontalPositionAdjustment = WorkflowExpression.Compile(bodyhorizontalPositionAdjustment, nameof(bodyhorizontalPositionAdjustment), required: false);
            var __workflow_bodyfontFamily = WorkflowExpression.Compile(bodyfontFamily, nameof(bodyfontFamily), required: false);
            var __workflow_bodyfontSize = WorkflowExpression.Compile(bodyfontSize, nameof(bodyfontSize), required: false);
            var __workflow_bodyfontColor = WorkflowExpression.Compile(bodyfontColor, nameof(bodyfontColor), required: false);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Merge(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyfileSource2Input>> bodyfileSource2 = null, Expression<Func<string>> bodyfileName2 = null, Expression<Func<string>> bodyfile2 = null, Expression<Func<string>> bodyfileUrl2 = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyfileSource2 = WorkflowExpression.Compile(bodyfileSource2, nameof(bodyfileSource2), required: false);
            var __workflow_bodyfileName2 = WorkflowExpression.Compile(bodyfileName2, nameof(bodyfileName2), required: false);
            var __workflow_bodyfile2 = WorkflowExpression.Compile(bodyfile2, nameof(bodyfile2), required: false);
            var __workflow_bodyfileUrl2 = WorkflowExpression.Compile(bodyfileUrl2, nameof(bodyfileUrl2), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Watermark(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodymodeInput>> bodymode = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyimageSource = null, Expression<Func<string>> bodyimageName = null, Expression<Func<string>> bodyimageFile = null, Expression<Func<string>> bodyimageUrl = null, Expression<Func<string>> bodypages = null, Expression<Func<bodyverticalPositionInput>> bodyverticalPosition = null, Expression<Func<bodyhorizontalPositionInput>> bodyhorizontalPosition = null, Expression<Func<string>> bodyverticalPositionAdjustment = null, Expression<Func<string>> bodyhorizontalPositionAdjustment = null, Expression<Func<bodymosaicInput>> bodymosaic = null, Expression<Func<string>> bodyrotation = null, Expression<Func<bodyfontFamilyInput>> bodyfontFamily = null, Expression<Func<bodyfontStyleInput>> bodyfontStyle = null, Expression<Func<string>> bodyfontSize = null, Expression<Func<string>> bodyfontColor = null, Expression<Func<string>> bodytransparency = null, Expression<Func<bodylayerInput>> bodylayer = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodymode = WorkflowExpression.Compile(bodymode, nameof(bodymode), required: false);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyimageSource = WorkflowExpression.Compile(bodyimageSource, nameof(bodyimageSource), required: false);
            var __workflow_bodyimageName = WorkflowExpression.Compile(bodyimageName, nameof(bodyimageName), required: false);
            var __workflow_bodyimageFile = WorkflowExpression.Compile(bodyimageFile, nameof(bodyimageFile), required: false);
            var __workflow_bodyimageUrl = WorkflowExpression.Compile(bodyimageUrl, nameof(bodyimageUrl), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodyverticalPosition = WorkflowExpression.Compile(bodyverticalPosition, nameof(bodyverticalPosition), required: false);
            var __workflow_bodyhorizontalPosition = WorkflowExpression.Compile(bodyhorizontalPosition, nameof(bodyhorizontalPosition), required: false);
            var __workflow_bodyverticalPositionAdjustment = WorkflowExpression.Compile(bodyverticalPositionAdjustment, nameof(bodyverticalPositionAdjustment), required: false);
            var __workflow_bodyhorizontalPositionAdjustment = WorkflowExpression.Compile(bodyhorizontalPositionAdjustment, nameof(bodyhorizontalPositionAdjustment), required: false);
            var __workflow_bodymosaic = WorkflowExpression.Compile(bodymosaic, nameof(bodymosaic), required: false);
            var __workflow_bodyrotation = WorkflowExpression.Compile(bodyrotation, nameof(bodyrotation), required: false);
            var __workflow_bodyfontFamily = WorkflowExpression.Compile(bodyfontFamily, nameof(bodyfontFamily), required: false);
            var __workflow_bodyfontStyle = WorkflowExpression.Compile(bodyfontStyle, nameof(bodyfontStyle), required: false);
            var __workflow_bodyfontSize = WorkflowExpression.Compile(bodyfontSize, nameof(bodyfontSize), required: false);
            var __workflow_bodyfontColor = WorkflowExpression.Compile(bodyfontColor, nameof(bodyfontColor), required: false);
            var __workflow_bodytransparency = WorkflowExpression.Compile(bodytransparency, nameof(bodytransparency), required: false);
            var __workflow_bodylayer = WorkflowExpression.Compile(bodylayer, nameof(bodylayer), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Rotate(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<bodyrotateInput>> bodyrotate = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyrotate = WorkflowExpression.Compile(bodyrotate, nameof(bodyrotate), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> PDFOCR(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyocrLanguages = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyocrLanguages = WorkflowExpression.Compile(bodyocrLanguages, nameof(bodyocrLanguages), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> OfficeToPDF(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DetectForms(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/detectforms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Summarize(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodyoutputFormat = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodyoutputFormat = WorkflowExpression.Compile(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/summarize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                if (__workflow_bodyoutputFormat != null)
                {
                    body["output_format"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFormat);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Translate(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodylanguageOutput = null, Expression<Func<string>> bodytranslateMode = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodylanguageOutput = WorkflowExpression.Compile(bodylanguageOutput, nameof(bodylanguageOutput), required: false);
            var __workflow_bodytranslateMode = WorkflowExpression.Compile(bodytranslateMode, nameof(bodytranslateMode), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodylanguageOutput != null)
                {
                    body["language_output"] = ExpressionConverter.ConvertO(__workflow_bodylanguageOutput);
                    bodypropCount++;
                }

                if (__workflow_bodytranslateMode != null)
                {
                    body["translate_mode"] = ExpressionConverter.ConvertO(__workflow_bodytranslateMode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> SplitSmart(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyprompt, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/splitsmart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> PDFMarkdown(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyFile = null, Expression<Func<string>> bodyfileUrl = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyFile = WorkflowExpression.Compile(bodyFile, nameof(bodyFile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdfmarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyFile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyFile);
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

                return new ApiConnectionAction<object>(callPayload);
            });
        }
    }

    public class Ilovepdfv2Triggers([ConnectionName] string connectionId)
    {
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypdfjpgModeInput
    {
        [EnumMember(Value = "pages")]
        Pages,
        [EnumMember(Value = "extract")]
        Extract
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfileSource2Input
    {
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "url")]
        Url
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