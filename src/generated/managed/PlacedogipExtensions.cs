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
        public IBodyWorkflowAction<GetWidthResponse> GetWidth([WorkflowExpression] Func<int> width, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(width, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<GetWidthResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "placedogip")]
        public IBodyWorkflowAction<GetWidthHeightResponse> GetWidthHeight([WorkflowExpression] Func<int> width, [WorkflowExpression] Func<int> height, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(width, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(height, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<GetWidthHeightResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "placedogip")]
        public IBodyWorkflowAction<GetWidthHeightFilterResponse> GetWidthHeightFilter([WorkflowExpression] Func<int> width, [WorkflowExpression] Func<int> height, [WorkflowExpression] Func<filterInput> filter, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(width, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(height, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filter, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<GetWidthHeightFilterResponse>(BuildSourceInput);
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