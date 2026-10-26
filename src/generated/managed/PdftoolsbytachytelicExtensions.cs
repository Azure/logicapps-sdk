//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdftoolsbytachytelic
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdftoolsbytachytelicActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdftoolsbytachytelic")]
        public IBodyWorkflowAction<OptimizePdfResponse, ApiConnectionActionConfiguration> OptimizePdf(Expression<Func<OptimizePdfInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OptimizePdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/optimize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OptimizePdfResponse>(callPayload);
            });
        }
    }

    public class PdftoolsbytachytelicTriggers([ConnectionName] string connectionId)
    {
    }

    public class OptimizePdfResponse
    {
        [JsonProperty("OptimizedPdf")]
        public string OptimizedPDF { get; set; }
    }

    public class OptimizePdfInput
    {
        [JsonProperty("PdfFileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PDFFileContent { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OptimizePdfInputModeType? Mode { get; set; } = OptimizePdfInputModeType.Aggressive;

        [JsonProperty("Garbage", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? GarbageLevel { get; set; } = 4;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Deflate { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Clean { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OptimizePdfInputModeType
    {
        [EnumMember(Value = "aggressive")]
        Aggressive,
        [EnumMember(Value = "safe")]
        Safe
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdftoolsbytachytelic;

    public partial class WorkflowManagedActions
    {
        public PdftoolsbytachytelicActions Pdftoolsbytachytelic(string connectionId) => new PdftoolsbytachytelicActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PdftoolsbytachytelicTriggers Pdftoolsbytachytelic(string connectionId) => new PdftoolsbytachytelicTriggers(connectionId);
    }
}