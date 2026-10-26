//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersiveimagepr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersiveimageprActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveimagepr")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDrawPolygon(Expression<Func<string>> requestbaseImageBytes = null, Expression<Func<string>> requestbaseImageUrl = null, Expression<Func<DrawPolygonInstance[]>> requestpolygonsToDraw = null)
        {
            var __workflow_requestbaseImageBytes = WorkflowExpression.Compile(requestbaseImageBytes, nameof(requestbaseImageBytes), required: false);
            var __workflow_requestbaseImageUrl = WorkflowExpression.Compile(requestbaseImageUrl, nameof(requestbaseImageUrl), required: false);
            var __workflow_requestpolygonsToDraw = WorkflowExpression.Compile(requestpolygonsToDraw, nameof(requestpolygonsToDraw), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image/edit/draw/polygon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestbaseImageBytes != null)
                {
                    request["BaseImageBytes"] = ExpressionConverter.ConvertO(__workflow_requestbaseImageBytes);
                    requestpropCount++;
                }

                if (__workflow_requestbaseImageUrl != null)
                {
                    request["BaseImageUrl"] = ExpressionConverter.ConvertO(__workflow_requestbaseImageUrl);
                    requestpropCount++;
                }

                if (__workflow_requestpolygonsToDraw != null)
                {
                    request["PolygonsToDraw"] = ExpressionConverter.ConvertO(__workflow_requestpolygonsToDraw);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveimagepr")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDrawRectangle(Expression<Func<string>> requestbaseImageBytes = null, Expression<Func<string>> requestbaseImageUrl = null, Expression<Func<DrawRectangleInstance[]>> requestrectanglesToDraw = null)
        {
            var __workflow_requestbaseImageBytes = WorkflowExpression.Compile(requestbaseImageBytes, nameof(requestbaseImageBytes), required: false);
            var __workflow_requestbaseImageUrl = WorkflowExpression.Compile(requestbaseImageUrl, nameof(requestbaseImageUrl), required: false);
            var __workflow_requestrectanglesToDraw = WorkflowExpression.Compile(requestrectanglesToDraw, nameof(requestrectanglesToDraw), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image/edit/draw/rectangle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestbaseImageBytes != null)
                {
                    request["BaseImageBytes"] = ExpressionConverter.ConvertO(__workflow_requestbaseImageBytes);
                    requestpropCount++;
                }

                if (__workflow_requestbaseImageUrl != null)
                {
                    request["BaseImageUrl"] = ExpressionConverter.ConvertO(__workflow_requestbaseImageUrl);
                    requestpropCount++;
                }

                if (__workflow_requestrectanglesToDraw != null)
                {
                    request["RectanglesToDraw"] = ExpressionConverter.ConvertO(__workflow_requestrectanglesToDraw);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveimagepr")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDrawText(Expression<Func<string>> requestbaseImageBytes = null, Expression<Func<string>> requestbaseImageUrl = null, Expression<Func<DrawTextInstance[]>> requesttextToDraw = null)
        {
            var __workflow_requestbaseImageBytes = WorkflowExpression.Compile(requestbaseImageBytes, nameof(requestbaseImageBytes), required: false);
            var __workflow_requestbaseImageUrl = WorkflowExpression.Compile(requestbaseImageUrl, nameof(requestbaseImageUrl), required: false);
            var __workflow_requesttextToDraw = WorkflowExpression.Compile(requesttextToDraw, nameof(requesttextToDraw), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image/edit/draw/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestbaseImageBytes != null)
                {
                    request["BaseImageBytes"] = ExpressionConverter.ConvertO(__workflow_requestbaseImageBytes);
                    requestpropCount++;
                }

                if (__workflow_requestbaseImageUrl != null)
                {
                    request["BaseImageUrl"] = ExpressionConverter.ConvertO(__workflow_requestbaseImageUrl);
                    requestpropCount++;
                }

                if (__workflow_requesttextToDraw != null)
                {
                    request["TextToDraw"] = ExpressionConverter.ConvertO(__workflow_requesttextToDraw);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class CloudmersiveimageprTriggers([ConnectionName] string connectionId)
    {
    }

    public class DrawPolygonInstance
    {
        public string BorderColor { get; set; }
        public double BorderWidth { get; set; }
        public string FillColor { get; set; }
        public PolygonPoint[] Points { get; set; }
    }

    public class PolygonPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class DrawRectangleInstance
    {
        public string BorderColor { get; set; }
        public double BorderWidth { get; set; }
        public string FillColor { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class DrawTextInstance
    {
        public string Color { get; set; }
        public string FontFamilyName { get; set; }
        public double FontSize { get; set; }
        public double Height { get; set; }
        public string Text { get; set; }
        public double Width { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersiveimagepr;

    public partial class WorkflowManagedActions
    {
        public CloudmersiveimageprActions Cloudmersiveimagepr(string connectionId) => new CloudmersiveimageprActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersiveimageprTriggers Cloudmersiveimagepr(string connectionId) => new CloudmersiveimageprTriggers(connectionId);
    }
}