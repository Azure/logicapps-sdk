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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdftoolsbytachytelic")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OptimizePdfResponse> __BuildOptimizePdf(WorkflowExpression<string> bodypDFFileContent, WorkflowExpression<bodymodeInput> bodymode = null, WorkflowExpression<int> bodygarbageLevel = null, WorkflowExpression<bool> bodydeflate = null, WorkflowExpression<bool> bodyclean = null)
        {
            WorkflowExpression.Validate(bodypDFFileContent, nameof(bodypDFFileContent), required: true);
            WorkflowExpression.Validate(bodymode, nameof(bodymode), required: false);
            WorkflowExpression.Validate(bodygarbageLevel, nameof(bodygarbageLevel), required: false);
            WorkflowExpression.Validate(bodydeflate, nameof(bodydeflate), required: false);
            WorkflowExpression.Validate(bodyclean, nameof(bodyclean), required: false);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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