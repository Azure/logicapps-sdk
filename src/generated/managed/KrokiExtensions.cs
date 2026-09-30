//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kroki
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KrokiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kroki")]
        public IBodyWorkflowAction<DiagramPostResponse> Diagram([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<libraryInput> library, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> output, [WorkflowExpression] Func<string> bodydiagramSource, [WorkflowExpression] Func<string> bodydiagramOptionskey = null, [WorkflowExpression] Func<string> bodydiagramOptionsantialias = null, [WorkflowExpression] Func<string> bodydiagramOptionsnoTransparency = null, [WorkflowExpression] Func<string> bodydiagramOptionssize = null, [WorkflowExpression] Func<string> bodydiagramOptionsnoDoctype = null, [WorkflowExpression] Func<string> bodydiagramOptionstheme = null, [WorkflowExpression] Func<string> bodydiagramOptionssketch = null, [WorkflowExpression] Func<string> bodydiagramOptionslayout = null, [WorkflowExpression] Func<int> bodydiagramOptionsscale = null, [WorkflowExpression] Func<string> bodydiagramOptionsviewKey = null, [WorkflowExpression] Func<string> bodydiagramOptionsbackground = null, [WorkflowExpression] Func<string> bodydiagramOptionsfontFamily = null, [WorkflowExpression] Func<int> bodydiagramOptionsfontSize = null, [WorkflowExpression] Func<int> bodydiagramOptionsstrokeWidth = null)
        {
            var apiCallPath = String.Format("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(library, 1), ExpressionConverter.ConvertWithUrlEncoding(output, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["diagram_source"] = ExpressionConverter.ConvertO(bodydiagramSource);
            var diagramOptionsObject = new JObject();
            var diagramOptionsObjectpropCount = 0;
            if (bodydiagramOptionskey != null)
            {
                diagramOptionsObject["key"] = ExpressionConverter.ConvertO(bodydiagramOptionskey);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionsantialias != null)
            {
                diagramOptionsObject["antialias"] = ExpressionConverter.ConvertO(bodydiagramOptionsantialias);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionsnoTransparency != null)
            {
                diagramOptionsObject["no-transparency"] = ExpressionConverter.ConvertO(bodydiagramOptionsnoTransparency);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionssize != null)
            {
                diagramOptionsObject["size"] = ExpressionConverter.ConvertO(bodydiagramOptionssize);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionsnoDoctype != null)
            {
                diagramOptionsObject["no-doctype"] = ExpressionConverter.ConvertO(bodydiagramOptionsnoDoctype);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionstheme != null)
            {
                diagramOptionsObject["theme"] = ExpressionConverter.ConvertO(bodydiagramOptionstheme);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionssketch != null)
            {
                diagramOptionsObject["sketch"] = ExpressionConverter.ConvertO(bodydiagramOptionssketch);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionslayout != null)
            {
                diagramOptionsObject["layout"] = ExpressionConverter.ConvertO(bodydiagramOptionslayout);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionsscale != null)
            {
                diagramOptionsObject["scale"] = ExpressionConverter.ConvertO(bodydiagramOptionsscale);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionsviewKey != null)
            {
                diagramOptionsObject["view-key"] = ExpressionConverter.ConvertO(bodydiagramOptionsviewKey);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionsbackground != null)
            {
                diagramOptionsObject["background"] = ExpressionConverter.ConvertO(bodydiagramOptionsbackground);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionsfontFamily != null)
            {
                diagramOptionsObject["font-family"] = ExpressionConverter.ConvertO(bodydiagramOptionsfontFamily);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionsfontSize != null)
            {
                diagramOptionsObject["font-size"] = ExpressionConverter.ConvertO(bodydiagramOptionsfontSize);
                diagramOptionsObjectpropCount++;
            }

            if (bodydiagramOptionsstrokeWidth != null)
            {
                diagramOptionsObject["stroke-width"] = ExpressionConverter.ConvertO(bodydiagramOptionsstrokeWidth);
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