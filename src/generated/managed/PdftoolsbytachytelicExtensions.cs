//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdftoolsbytachytelic
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdftoolsbytachytelicActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdftoolsbytachytelic")]
        public IBodyWorkflowAction<OptimizePdfResponse> OptimizePdf([WorkflowExpression] Func<string> bodypDFFileContent, [WorkflowExpression] Func<bodymodeInput> bodymode = null, [WorkflowExpression] Func<int> bodygarbageLevel = null, [WorkflowExpression] Func<bool> bodydeflate = null, [WorkflowExpression] Func<bool> bodyclean = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/optimize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["PdfFileContent"] = SourceExpressionConverter.ConvertToken(bodypDFFileContent);
                if (bodymode != null)
                {
                    if (bodymode != null)
                    {
                        body["Mode"] = SourceExpressionConverter.Convert(bodymode);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Mode"] = "aggressive";
                    bodypropCount++;
                }

                if (bodygarbageLevel != null)
                {
                    if (bodygarbageLevel != null)
                    {
                        body["Garbage"] = SourceExpressionConverter.ConvertToken(bodygarbageLevel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Garbage"] = 4;
                    bodypropCount++;
                }

                if (bodydeflate != null)
                {
                    if (bodydeflate != null)
                    {
                        body["Deflate"] = SourceExpressionConverter.ConvertToken(bodydeflate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Deflate"] = true;
                    bodypropCount++;
                }

                if (bodyclean != null)
                {
                    if (bodyclean != null)
                    {
                        body["Clean"] = SourceExpressionConverter.ConvertToken(bodyclean);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Clean"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OptimizePdfResponse>(BuildSourceInput);
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

    public enum bodymodeInput
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