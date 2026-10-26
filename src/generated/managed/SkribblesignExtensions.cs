//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Skribblesign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SkribblesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skribblesign")]
        public IBodyWorkflowAction<ErrorResponse, ApiConnectionActionConfiguration> CreateSeal(Expression<Func<CreateSealInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ErrorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/seal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ErrorResponse>(callPayload);
            });
        }
    }

    public class SkribblesignTriggers([ConnectionName] string connectionId)
    {
    }

    public class ErrorResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("method")]
        public ErrorResponseMethodType Method { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorResponseMethodType
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class CreateSealInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("account_name")]
        public string SealForSealing { get; set; }

        [JsonProperty("visual_signature")]
        public VisualSignature VisualSignature { get; set; }
    }

    public class VisualSignature
    {
        [JsonProperty("form_field")]
        public string FormField { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("positions")]
        public Position[] Positions { get; set; }
    }

    public class Image
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }
    }

    public class Position
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("rotation")]
        public int Rotation { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Skribblesign;

    public partial class WorkflowManagedActions
    {
        public SkribblesignActions Skribblesign(string connectionId) => new SkribblesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SkribblesignTriggers Skribblesign(string connectionId) => new SkribblesignTriggers(connectionId);
    }
}