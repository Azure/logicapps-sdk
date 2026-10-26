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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDrawPolygon(Expression<Func<EditDrawPolygonInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image/edit/draw/polygon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveimagepr")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDrawRectangle(Expression<Func<EditDrawRectangleInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image/edit/draw/rectangle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveimagepr")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDrawText(Expression<Func<EditDrawTextInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image/edit/draw/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class CloudmersiveimageprTriggers([ConnectionName] string connectionId)
    {
    }

    public class EditDrawPolygonInput
    {
        public string BaseImageBytes { get; set; }
        public string BaseImageUrl { get; set; }
        public DrawPolygonInstance[] PolygonsToDraw { get; set; }
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

    public class EditDrawRectangleInput
    {
        public string BaseImageBytes { get; set; }
        public string BaseImageUrl { get; set; }
        public DrawRectangleInstance[] RectanglesToDraw { get; set; }
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

    public class EditDrawTextInput
    {
        public string BaseImageBytes { get; set; }
        public string BaseImageUrl { get; set; }
        public DrawTextInstance[] TextToDraw { get; set; }
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