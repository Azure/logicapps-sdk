//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdftoolsbytachytelic
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdftoolsbytachytelicActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdftoolsbytachytelic")]
        [WorkflowExpressionFactory(nameof(__BuildOptimizePdf))]
        public IBodyWorkflowAction<OptimizePdfResponse> OptimizePdf([WorkflowExpression] Func<string> bodypDFFileContent, [WorkflowExpression] Func<bodymodeInput> bodymode = null, [WorkflowExpression] Func<int> bodygarbageLevel = null, [WorkflowExpression] Func<bool> bodydeflate = null, [WorkflowExpression] Func<bool> bodyclean = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OptimizePdfResponse> __BuildOptimizePdf(WorkflowValue<string> bodypDFFileContent, WorkflowValue<bodymodeInput> bodymode = null, WorkflowValue<int> bodygarbageLevel = null, WorkflowValue<bool> bodydeflate = null, WorkflowValue<bool> bodyclean = null)
        {
            WorkflowValue.Validate(bodypDFFileContent, nameof(bodypDFFileContent), required: true);
            WorkflowValue.Validate(bodymode, nameof(bodymode), required: false);
            WorkflowValue.Validate(bodygarbageLevel, nameof(bodygarbageLevel), required: false);
            WorkflowValue.Validate(bodydeflate, nameof(bodydeflate), required: false);
            WorkflowValue.Validate(bodyclean, nameof(bodyclean), required: false);
            return new DeferredBodyAction<OptimizePdfResponse>(() =>
            {
                var apiCallPath = "/optimize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["PdfFileContent"] = ExpressionConverter.ConvertO(bodypDFFileContent);
                if (bodymode != null)
                {
                    if (bodymode != null)
                    {
                        body["Mode"] = ExpressionConverter.ConvertO(bodymode);
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
                        body["Garbage"] = ExpressionConverter.ConvertO(bodygarbageLevel);
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
                        body["Deflate"] = ExpressionConverter.ConvertO(bodydeflate);
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
                        body["Clean"] = ExpressionConverter.ConvertO(bodyclean);
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
