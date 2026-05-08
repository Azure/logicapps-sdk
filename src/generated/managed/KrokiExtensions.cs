//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kroki
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KrokiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kroki")]
        public IBodyWorkflowAction<DiagramPostResponse> Diagram(Expression<Func<libraryInput>> library, Expression<Func<string>> output, Expression<Func<string>> bodydiagramSource, Expression<Func<string>> bodydiagramOptionskey = null, Expression<Func<string>> bodydiagramOptionsantialias = null, Expression<Func<string>> bodydiagramOptionsnoTransparency = null, Expression<Func<string>> bodydiagramOptionssize = null, Expression<Func<string>> bodydiagramOptionsnoDoctype = null, Expression<Func<string>> bodydiagramOptionstheme = null, Expression<Func<string>> bodydiagramOptionssketch = null, Expression<Func<string>> bodydiagramOptionslayout = null, Expression<Func<int>> bodydiagramOptionsscale = null, Expression<Func<string>> bodydiagramOptionsviewKey = null, Expression<Func<string>> bodydiagramOptionsbackground = null, Expression<Func<string>> bodydiagramOptionsfontFamily = null, Expression<Func<int>> bodydiagramOptionsfontSize = null, Expression<Func<int>> bodydiagramOptionsstrokeWidth = null)
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