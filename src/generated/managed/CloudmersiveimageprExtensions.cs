//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersiveimagepr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersiveimageprActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveimagepr")]
        public IBodyWorkflowAction<string> EditDrawPolygon([WorkflowExpression] Func<string> requestbaseImageBytes = null, [WorkflowExpression] Func<string> requestbaseImageUrl = null, [WorkflowExpression] Func<DrawPolygonInstance[]> requestpolygonsToDraw = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/image/edit/draw/polygon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestbaseImageBytes != null)
                {
                    request["BaseImageBytes"] = SourceExpressionConverter.ConvertToken(requestbaseImageBytes);
                    requestpropCount++;
                }

                if (requestbaseImageUrl != null)
                {
                    request["BaseImageUrl"] = SourceExpressionConverter.ConvertToken(requestbaseImageUrl);
                    requestpropCount++;
                }

                if (requestpolygonsToDraw != null)
                {
                    request["PolygonsToDraw"] = SourceExpressionConverter.ConvertToken(requestpolygonsToDraw);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveimagepr")]
        public IBodyWorkflowAction<string> EditDrawRectangle([WorkflowExpression] Func<string> requestbaseImageBytes = null, [WorkflowExpression] Func<string> requestbaseImageUrl = null, [WorkflowExpression] Func<DrawRectangleInstance[]> requestrectanglesToDraw = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/image/edit/draw/rectangle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestbaseImageBytes != null)
                {
                    request["BaseImageBytes"] = SourceExpressionConverter.ConvertToken(requestbaseImageBytes);
                    requestpropCount++;
                }

                if (requestbaseImageUrl != null)
                {
                    request["BaseImageUrl"] = SourceExpressionConverter.ConvertToken(requestbaseImageUrl);
                    requestpropCount++;
                }

                if (requestrectanglesToDraw != null)
                {
                    request["RectanglesToDraw"] = SourceExpressionConverter.ConvertToken(requestrectanglesToDraw);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveimagepr")]
        public IBodyWorkflowAction<string> EditDrawText([WorkflowExpression] Func<string> requestbaseImageBytes = null, [WorkflowExpression] Func<string> requestbaseImageUrl = null, [WorkflowExpression] Func<DrawTextInstance[]> requesttextToDraw = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/image/edit/draw/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestbaseImageBytes != null)
                {
                    request["BaseImageBytes"] = SourceExpressionConverter.ConvertToken(requestbaseImageBytes);
                    requestpropCount++;
                }

                if (requestbaseImageUrl != null)
                {
                    request["BaseImageUrl"] = SourceExpressionConverter.ConvertToken(requestbaseImageUrl);
                    requestpropCount++;
                }

                if (requesttextToDraw != null)
                {
                    request["TextToDraw"] = SourceExpressionConverter.ConvertToken(requesttextToDraw);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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