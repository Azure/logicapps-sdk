//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Kroki
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KrokiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kroki")]
        public IBodyWorkflowAction<DiagramPostResponse> DiagramPost(Expression<Func<libraryInput>> library, Expression<Func<string>> output, Expression<Func<string>> bodydiagramSource, Expression<Func<string>> bodydiagramOptionskey = null, Expression<Func<string>> bodydiagramOptionsantialias = null, Expression<Func<string>> bodydiagramOptionsnoTransparency = null, Expression<Func<string>> bodydiagramOptionssize = null, Expression<Func<string>> bodydiagramOptionsnoDoctype = null, Expression<Func<string>> bodydiagramOptionstheme = null, Expression<Func<string>> bodydiagramOptionssketch = null, Expression<Func<string>> bodydiagramOptionslayout = null, Expression<Func<int>> bodydiagramOptionsscale = null, Expression<Func<string>> bodydiagramOptionsviewKey = null, Expression<Func<string>> bodydiagramOptionsbackground = null, Expression<Func<string>> bodydiagramOptionsfontFamily = null, Expression<Func<int>> bodydiagramOptionsfontSize = null, Expression<Func<int>> bodydiagramOptionsstrokeWidth = null)
        {
            var apiCallPath = String.Format("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(library, 1), ExpressionConverter.ConvertWithUrlEncoding(output, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["diagram_source"] = ExpressionConverter.ConvertO(bodydiagramSource);
            var diagram_optionsObject = new JObject();
            var diagram_optionsObjectpropCount = 0;
            if (bodydiagramOptionskey != null)
            {
                diagram_optionsObject["key"] = ExpressionConverter.ConvertO(bodydiagramOptionskey);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionsantialias != null)
            {
                diagram_optionsObject["antialias"] = ExpressionConverter.ConvertO(bodydiagramOptionsantialias);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionsnoTransparency != null)
            {
                diagram_optionsObject["no-transparency"] = ExpressionConverter.ConvertO(bodydiagramOptionsnoTransparency);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionssize != null)
            {
                diagram_optionsObject["size"] = ExpressionConverter.ConvertO(bodydiagramOptionssize);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionsnoDoctype != null)
            {
                diagram_optionsObject["no-doctype"] = ExpressionConverter.ConvertO(bodydiagramOptionsnoDoctype);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionstheme != null)
            {
                diagram_optionsObject["theme"] = ExpressionConverter.ConvertO(bodydiagramOptionstheme);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionssketch != null)
            {
                diagram_optionsObject["sketch"] = ExpressionConverter.ConvertO(bodydiagramOptionssketch);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionslayout != null)
            {
                diagram_optionsObject["layout"] = ExpressionConverter.ConvertO(bodydiagramOptionslayout);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionsscale != null)
            {
                diagram_optionsObject["scale"] = ExpressionConverter.ConvertO(bodydiagramOptionsscale);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionsviewKey != null)
            {
                diagram_optionsObject["view-key"] = ExpressionConverter.ConvertO(bodydiagramOptionsviewKey);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionsbackground != null)
            {
                diagram_optionsObject["background"] = ExpressionConverter.ConvertO(bodydiagramOptionsbackground);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionsfontFamily != null)
            {
                diagram_optionsObject["font-family"] = ExpressionConverter.ConvertO(bodydiagramOptionsfontFamily);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionsfontSize != null)
            {
                diagram_optionsObject["font-size"] = ExpressionConverter.ConvertO(bodydiagramOptionsfontSize);
                diagram_optionsObjectpropCount++;
            }

            if (bodydiagramOptionsstrokeWidth != null)
            {
                diagram_optionsObject["stroke-width"] = ExpressionConverter.ConvertO(bodydiagramOptionsstrokeWidth);
                diagram_optionsObjectpropCount++;
            }

            if (diagram_optionsObjectpropCount > 0)
            {
                body["diagram_options"] = diagram_optionsObject;
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
    using Microsoft.Azure.Workflows.Sdk.Kroki;

    public partial class WorkflowManagedActions
    {
        public KrokiActions Kroki(string connectionId) => new KrokiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KrokiTriggers Kroki(string connectionId) => new KrokiTriggers(connectionId);
    }
}