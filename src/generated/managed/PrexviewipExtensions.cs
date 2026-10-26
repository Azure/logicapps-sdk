//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Prexviewip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PrexviewipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prexviewip")]
        public IBodyWorkflowAction<TransformPostResponse, ApiConnectionActionConfiguration> Transform(Expression<Func<TransformPostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TransformPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/transform";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TransformPostResponse>(callPayload);
            });
        }
    }

    public class PrexviewipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TransformPostResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class TransformPostInput
    {
        [JsonProperty("xml")]
        public string Xml { get; set; }

        [JsonProperty("json")]
        public string Json { get; set; }

        [JsonProperty("output", DefaultValueHandling = DefaultValueHandling.Include)]
        public TransformPostInputOutputType Output { get; set; } = TransformPostInputOutputType.Pdf;

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Template { get; set; }

        [JsonProperty("templateBackup")]
        public string TemplateBackup { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TransformPostInputOutputType
    {
        [EnumMember(Value = "pdf")]
        Pdf,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "jpg")]
        Jpg,
        [EnumMember(Value = "png")]
        Png
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Prexviewip;

    public partial class WorkflowManagedActions
    {
        public PrexviewipActions Prexviewip(string connectionId) => new PrexviewipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PrexviewipTriggers Prexviewip(string connectionId) => new PrexviewipTriggers(connectionId);
    }
}