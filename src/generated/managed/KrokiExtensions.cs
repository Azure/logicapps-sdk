//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kroki
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KrokiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kroki")]
        public IBodyWorkflowAction<DiagramPostResponse, ApiConnectionActionConfiguration> Diagram(Expression<Func<libraryInput>> library, Expression<Func<string>> output, Expression<Func<DiagramPostInput>> body = null)
        {
            var __workflow_library = WorkflowExpression.Compile(library, nameof(library), required: true);
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DiagramPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}", __workflow_library.WithUrlEncoding(1), __workflow_output.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DiagramPostResponse>(callPayload);
            });
        }
    }

    public class KrokiTriggers([ConnectionName] string connectionId)
    {
    }

    public class DiagramPostResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum libraryInput
    {
        [EnumMember(Value = "graphviz")]
        Graphviz,
        [EnumMember(Value = "blockdiag")]
        Blockdiag,
        [EnumMember(Value = "seqdiag")]
        Seqdiag,
        [EnumMember(Value = "actdiag")]
        Actdiag,
        [EnumMember(Value = "nwdiag")]
        Nwdiag,
        [EnumMember(Value = "packetdiag")]
        Packetdiag,
        [EnumMember(Value = "rackdiag")]
        Rackdiag,
        [EnumMember(Value = "pihchr")]
        Pihchr,
        [EnumMember(Value = "erd")]
        Erd,
        [EnumMember(Value = "excalidraw")]
        Excalidraw,
        [EnumMember(Value = "vega")]
        Vega,
        [EnumMember(Value = "vegalite")]
        Vegalite,
        [EnumMember(Value = "ditaa")]
        Ditaa,
        [EnumMember(Value = "mermaid")]
        Mermaid,
        [EnumMember(Value = "nomnoml.plantuml")]
        NomnomlPlantuml,
        [EnumMember(Value = "bpmn")]
        Bpmn,
        [EnumMember(Value = "bytefield")]
        Bytefield,
        [EnumMember(Value = "wavedrom")]
        Wavedrom,
        [EnumMember(Value = "svgbob")]
        Svgbob,
        [EnumMember(Value = "c4plantuml")]
        C4plantuml,
        [EnumMember(Value = "structurizr")]
        Structurizr,
        [EnumMember(Value = "umlet")]
        Umlet
    }

    public class DiagramPostInput
    {
        [JsonProperty("diagram_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DiagramSource { get; set; }

        [JsonProperty("diagram_options")]
        public DiagramPostInputDiagramOptionsType DiagramOptions { get; set; }
    }

    public class DiagramPostInputDiagramOptionsType
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("antialias")]
        public string Antialias { get; set; }

        [JsonProperty("no-transparency")]
        public string NoTransparency { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("no-doctype")]
        public string NoDoctype { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("sketch")]
        public string Sketch { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("scale")]
        public int? Scale { get; set; }

        [JsonProperty("view-key")]
        public string ViewKey { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("font-family")]
        public string FontFamily { get; set; }

        [JsonProperty("font-size")]
        public int? FontSize { get; set; }

        [JsonProperty("stroke-width")]
        public int? StrokeWidth { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Kroki;

    public partial class WorkflowManagedActions
    {
        public KrokiActions Kroki(string connectionId) => new KrokiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KrokiTriggers Kroki(string connectionId) => new KrokiTriggers(connectionId);
    }
}