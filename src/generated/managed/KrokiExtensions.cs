//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kroki
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class KrokiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kroki")]
        public IBodyWorkflowAction<DiagramPostResponse> Diagram(Expression<Func<libraryInput>> library, Expression<Func<string>> output, Expression<Func<string>> bodydiagramSource, Expression<Func<string>> bodydiagramOptionskey = null, Expression<Func<string>> bodydiagramOptionsantialias = null, Expression<Func<string>> bodydiagramOptionsnoTransparency = null, Expression<Func<string>> bodydiagramOptionssize = null, Expression<Func<string>> bodydiagramOptionsnoDoctype = null, Expression<Func<string>> bodydiagramOptionstheme = null, Expression<Func<string>> bodydiagramOptionssketch = null, Expression<Func<string>> bodydiagramOptionslayout = null, Expression<Func<int>> bodydiagramOptionsscale = null, Expression<Func<string>> bodydiagramOptionsviewKey = null, Expression<Func<string>> bodydiagramOptionsbackground = null, Expression<Func<string>> bodydiagramOptionsfontFamily = null, Expression<Func<int>> bodydiagramOptionsfontSize = null, Expression<Func<int>> bodydiagramOptionsstrokeWidth = null)
        {
            var __workflow_library = WorkflowExpression.Compile(library, nameof(library), required: true);
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: true);
            var __workflow_bodydiagramSource = WorkflowExpression.Compile(bodydiagramSource, nameof(bodydiagramSource), required: true);
            var __workflow_bodydiagramOptionskey = WorkflowExpression.Compile(bodydiagramOptionskey, nameof(bodydiagramOptionskey), required: false);
            var __workflow_bodydiagramOptionsantialias = WorkflowExpression.Compile(bodydiagramOptionsantialias, nameof(bodydiagramOptionsantialias), required: false);
            var __workflow_bodydiagramOptionsnoTransparency = WorkflowExpression.Compile(bodydiagramOptionsnoTransparency, nameof(bodydiagramOptionsnoTransparency), required: false);
            var __workflow_bodydiagramOptionssize = WorkflowExpression.Compile(bodydiagramOptionssize, nameof(bodydiagramOptionssize), required: false);
            var __workflow_bodydiagramOptionsnoDoctype = WorkflowExpression.Compile(bodydiagramOptionsnoDoctype, nameof(bodydiagramOptionsnoDoctype), required: false);
            var __workflow_bodydiagramOptionstheme = WorkflowExpression.Compile(bodydiagramOptionstheme, nameof(bodydiagramOptionstheme), required: false);
            var __workflow_bodydiagramOptionssketch = WorkflowExpression.Compile(bodydiagramOptionssketch, nameof(bodydiagramOptionssketch), required: false);
            var __workflow_bodydiagramOptionslayout = WorkflowExpression.Compile(bodydiagramOptionslayout, nameof(bodydiagramOptionslayout), required: false);
            var __workflow_bodydiagramOptionsscale = WorkflowExpression.Compile(bodydiagramOptionsscale, nameof(bodydiagramOptionsscale), required: false);
            var __workflow_bodydiagramOptionsviewKey = WorkflowExpression.Compile(bodydiagramOptionsviewKey, nameof(bodydiagramOptionsviewKey), required: false);
            var __workflow_bodydiagramOptionsbackground = WorkflowExpression.Compile(bodydiagramOptionsbackground, nameof(bodydiagramOptionsbackground), required: false);
            var __workflow_bodydiagramOptionsfontFamily = WorkflowExpression.Compile(bodydiagramOptionsfontFamily, nameof(bodydiagramOptionsfontFamily), required: false);
            var __workflow_bodydiagramOptionsfontSize = WorkflowExpression.Compile(bodydiagramOptionsfontSize, nameof(bodydiagramOptionsfontSize), required: false);
            var __workflow_bodydiagramOptionsstrokeWidth = WorkflowExpression.Compile(bodydiagramOptionsstrokeWidth, nameof(bodydiagramOptionsstrokeWidth), required: false);
            return new DeferredBodyAction<DiagramPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_library, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_output, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["diagram_source"] = ExpressionConverter.ConvertO(__workflow_bodydiagramSource);
                var diagramOptionsObject = new JObject();
                var diagramOptionsObjectpropCount = 0;
                if (__workflow_bodydiagramOptionskey != null)
                {
                    diagramOptionsObject["key"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionskey);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionsantialias != null)
                {
                    diagramOptionsObject["antialias"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionsantialias);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionsnoTransparency != null)
                {
                    diagramOptionsObject["no-transparency"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionsnoTransparency);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionssize != null)
                {
                    diagramOptionsObject["size"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionssize);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionsnoDoctype != null)
                {
                    diagramOptionsObject["no-doctype"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionsnoDoctype);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionstheme != null)
                {
                    diagramOptionsObject["theme"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionstheme);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionssketch != null)
                {
                    diagramOptionsObject["sketch"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionssketch);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionslayout != null)
                {
                    diagramOptionsObject["layout"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionslayout);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionsscale != null)
                {
                    diagramOptionsObject["scale"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionsscale);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionsviewKey != null)
                {
                    diagramOptionsObject["view-key"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionsviewKey);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionsbackground != null)
                {
                    diagramOptionsObject["background"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionsbackground);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionsfontFamily != null)
                {
                    diagramOptionsObject["font-family"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionsfontFamily);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionsfontSize != null)
                {
                    diagramOptionsObject["font-size"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionsfontSize);
                    diagramOptionsObjectpropCount++;
                }

                if (__workflow_bodydiagramOptionsstrokeWidth != null)
                {
                    diagramOptionsObject["stroke-width"] = ExpressionConverter.ConvertO(__workflow_bodydiagramOptionsstrokeWidth);
                    diagramOptionsObjectpropCount++;
                }

                if (diagramOptionsObjectpropCount > 0)
                {
                    body["diagram_options"] = diagramOptionsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
