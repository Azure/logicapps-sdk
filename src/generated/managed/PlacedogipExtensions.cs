//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Placedogip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlacedogipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "placedogip")]
        public IBodyWorkflowAction<GetWidthResponse, ApiConnectionActionConfiguration> GetWidth(Expression<Func<int>> width, Expression<Func<int>> id = null)
        {
            var __workflow_width = WorkflowExpression.Compile(width, nameof(width), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<GetWidthResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_width.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<GetWidthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "placedogip")]
        public IBodyWorkflowAction<GetWidthHeightResponse, ApiConnectionActionConfiguration> GetWidthHeight(Expression<Func<int>> width, Expression<Func<int>> height, Expression<Func<int>> id = null)
        {
            var __workflow_width = WorkflowExpression.Compile(width, nameof(width), required: true);
            var __workflow_height = WorkflowExpression.Compile(height, nameof(height), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<GetWidthHeightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}", __workflow_width.WithUrlEncoding(1), __workflow_height.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<GetWidthHeightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "placedogip")]
        public IBodyWorkflowAction<GetWidthHeightFilterResponse, ApiConnectionActionConfiguration> GetWidthHeightFilter(Expression<Func<int>> width, Expression<Func<int>> height, Expression<Func<filterInput>> filter, Expression<Func<int>> id = null)
        {
            var __workflow_width = WorkflowExpression.Compile(width, nameof(width), required: true);
            var __workflow_height = WorkflowExpression.Compile(height, nameof(height), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<GetWidthHeightFilterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}", __workflow_width.WithUrlEncoding(1), __workflow_height.WithUrlEncoding(1), __workflow_filter.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<GetWidthHeightFilterResponse>(callPayload);
            });
        }
    }

    public class PlacedogipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetWidthResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class GetWidthHeightResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class GetWidthHeightFilterResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filterInput
    {
        [EnumMember(Value = "greyscale")]
        Greyscale,
        [EnumMember(Value = "pixelate")]
        Pixelate,
        [EnumMember(Value = "blur")]
        Blur,
        [EnumMember(Value = "invert")]
        Invert,
        [EnumMember(Value = "sepia")]
        Sepia,
        [EnumMember(Value = "brightness")]
        Brightness,
        [EnumMember(Value = "contrast")]
        Contrast
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Placedogip;

    public partial class WorkflowManagedActions
    {
        public PlacedogipActions Placedogip(string connectionId) => new PlacedogipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlacedogipTriggers Placedogip(string connectionId) => new PlacedogipTriggers(connectionId);
    }
}