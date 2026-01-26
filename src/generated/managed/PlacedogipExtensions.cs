//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Placedogip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlacedogipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "placedogip")]
        public IBodyWorkflowAction<GetWidthResponse> GetWidth(Expression<Func<int>> width, Expression<Func<int>> id = null)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(width, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<GetWidthResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "placedogip")]
        public IBodyWorkflowAction<GetWidthHeightResponse> GetWidthHeight(Expression<Func<int>> width, Expression<Func<int>> height, Expression<Func<int>> id = null)
        {
            var apiCallPath = String.Format("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(width, 1), ExpressionConverter.ConvertWithUrlEncoding(height, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<GetWidthHeightResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "placedogip")]
        public IBodyWorkflowAction<GetWidthHeightFilterResponse> GetWidthHeightFilter(Expression<Func<int>> width, Expression<Func<int>> height, Expression<Func<filterInput>> filter, Expression<Func<int>> id = null)
        {
            var apiCallPath = String.Format("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(width, 1), ExpressionConverter.ConvertWithUrlEncoding(height, 1), ExpressionConverter.ConvertWithUrlEncoding(filter, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<GetWidthHeightFilterResponse>(callPayload);
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