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
        public IBodyWorkflowAction<DiagramPostResponse> Diagram([WorkflowExpression] Func<libraryInput> library, [WorkflowExpression] Func<string> output, [WorkflowExpression] Func<string> bodydiagramSource, [WorkflowExpression] Func<string> bodydiagramOptionskey = null, [WorkflowExpression] Func<string> bodydiagramOptionsantialias = null, [WorkflowExpression] Func<string> bodydiagramOptionsnoTransparency = null, [WorkflowExpression] Func<string> bodydiagramOptionssize = null, [WorkflowExpression] Func<string> bodydiagramOptionsnoDoctype = null, [WorkflowExpression] Func<string> bodydiagramOptionstheme = null, [WorkflowExpression] Func<string> bodydiagramOptionssketch = null, [WorkflowExpression] Func<string> bodydiagramOptionslayout = null, [WorkflowExpression] Func<int> bodydiagramOptionsscale = null, [WorkflowExpression] Func<string> bodydiagramOptionsviewKey = null, [WorkflowExpression] Func<string> bodydiagramOptionsbackground = null, [WorkflowExpression] Func<string> bodydiagramOptionsfontFamily = null, [WorkflowExpression] Func<int> bodydiagramOptionsfontSize = null, [WorkflowExpression] Func<int> bodydiagramOptionsstrokeWidth = null)
        {
            SourceExpression.Validate(library, nameof(library), required: true);
            SourceExpression.Validate(output, nameof(output), required: true);
            SourceExpression.Validate(bodydiagramSource, nameof(bodydiagramSource), required: true);
            SourceExpression.Validate(bodydiagramOptionskey, nameof(bodydiagramOptionskey), required: false);
            SourceExpression.Validate(bodydiagramOptionsantialias, nameof(bodydiagramOptionsantialias), required: false);
            SourceExpression.Validate(bodydiagramOptionsnoTransparency, nameof(bodydiagramOptionsnoTransparency), required: false);
            SourceExpression.Validate(bodydiagramOptionssize, nameof(bodydiagramOptionssize), required: false);
            SourceExpression.Validate(bodydiagramOptionsnoDoctype, nameof(bodydiagramOptionsnoDoctype), required: false);
            SourceExpression.Validate(bodydiagramOptionstheme, nameof(bodydiagramOptionstheme), required: false);
            SourceExpression.Validate(bodydiagramOptionssketch, nameof(bodydiagramOptionssketch), required: false);
            SourceExpression.Validate(bodydiagramOptionslayout, nameof(bodydiagramOptionslayout), required: false);
            SourceExpression.Validate(bodydiagramOptionsscale, nameof(bodydiagramOptionsscale), required: false);
            SourceExpression.Validate(bodydiagramOptionsviewKey, nameof(bodydiagramOptionsviewKey), required: false);
            SourceExpression.Validate(bodydiagramOptionsbackground, nameof(bodydiagramOptionsbackground), required: false);
            SourceExpression.Validate(bodydiagramOptionsfontFamily, nameof(bodydiagramOptionsfontFamily), required: false);
            SourceExpression.Validate(bodydiagramOptionsfontSize, nameof(bodydiagramOptionsfontSize), required: false);
            SourceExpression.Validate(bodydiagramOptionsstrokeWidth, nameof(bodydiagramOptionsstrokeWidth), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(library, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(output, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["diagram_source"] = SourceExpressionConverter.ConvertToken(bodydiagramSource);
                var diagramOptionsObject = new JObject();
                var diagramOptionsObjectpropCount = 0;
                if (bodydiagramOptionskey != null)
                {
                    diagramOptionsObject["key"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionskey);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionsantialias != null)
                {
                    diagramOptionsObject["antialias"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionsantialias);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionsnoTransparency != null)
                {
                    diagramOptionsObject["no-transparency"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionsnoTransparency);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionssize != null)
                {
                    diagramOptionsObject["size"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionssize);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionsnoDoctype != null)
                {
                    diagramOptionsObject["no-doctype"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionsnoDoctype);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionstheme != null)
                {
                    diagramOptionsObject["theme"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionstheme);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionssketch != null)
                {
                    diagramOptionsObject["sketch"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionssketch);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionslayout != null)
                {
                    diagramOptionsObject["layout"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionslayout);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionsscale != null)
                {
                    diagramOptionsObject["scale"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionsscale);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionsviewKey != null)
                {
                    diagramOptionsObject["view-key"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionsviewKey);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionsbackground != null)
                {
                    diagramOptionsObject["background"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionsbackground);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionsfontFamily != null)
                {
                    diagramOptionsObject["font-family"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionsfontFamily);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionsfontSize != null)
                {
                    diagramOptionsObject["font-size"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionsfontSize);
                    diagramOptionsObjectpropCount++;
                }

                if (bodydiagramOptionsstrokeWidth != null)
                {
                    diagramOptionsObject["stroke-width"] = SourceExpressionConverter.ConvertToken(bodydiagramOptionsstrokeWidth);
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
                return callPayload;
            }

            return new ApiConnectionAction<DiagramPostResponse>(BuildSourceInput);
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