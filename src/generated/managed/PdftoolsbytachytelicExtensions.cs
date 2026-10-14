//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdftoolsbytachytelic
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PdftoolsbytachytelicActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdftoolsbytachytelic")]
        public IBodyWorkflowAction<OptimizePdfResponse> OptimizePdf(Expression<Func<string>> bodypDFFileContent, Expression<Func<bodymodeInput>> bodymode = null, Expression<Func<int>> bodygarbageLevel = null, Expression<Func<bool>> bodydeflate = null, Expression<Func<bool>> bodyclean = null)
        {
            var __workflow_bodypDFFileContent = bodypDFFileContent == null ? null : WorkflowExpression.Compile(bodypDFFileContent);
            WorkflowExpression.Validate(__workflow_bodypDFFileContent, nameof(bodypDFFileContent), required: true);
            var __workflow_bodymode = bodymode == null ? null : WorkflowExpression.Compile(bodymode);
            WorkflowExpression.Validate(__workflow_bodymode, nameof(bodymode), required: false);
            var __workflow_bodygarbageLevel = bodygarbageLevel == null ? null : WorkflowExpression.Compile(bodygarbageLevel);
            WorkflowExpression.Validate(__workflow_bodygarbageLevel, nameof(bodygarbageLevel), required: false);
            var __workflow_bodydeflate = bodydeflate == null ? null : WorkflowExpression.Compile(bodydeflate);
            WorkflowExpression.Validate(__workflow_bodydeflate, nameof(bodydeflate), required: false);
            var __workflow_bodyclean = bodyclean == null ? null : WorkflowExpression.Compile(bodyclean);
            WorkflowExpression.Validate(__workflow_bodyclean, nameof(bodyclean), required: false);
            return new DeferredBodyAction<OptimizePdfResponse>(() =>
            {
                var apiCallPath = "/optimize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["PdfFileContent"] = ExpressionConverter.ConvertO(__workflow_bodypDFFileContent);
                if (__workflow_bodymode != null)
                {
                    if (__workflow_bodymode != null)
                    {
                        body["Mode"] = ExpressionConverter.ConvertO(__workflow_bodymode);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Mode"] = "aggressive";
                    bodypropCount++;
                }

                if (__workflow_bodygarbageLevel != null)
                {
                    if (__workflow_bodygarbageLevel != null)
                    {
                        body["Garbage"] = ExpressionConverter.ConvertO(__workflow_bodygarbageLevel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Garbage"] = 4;
                    bodypropCount++;
                }

                if (__workflow_bodydeflate != null)
                {
                    if (__workflow_bodydeflate != null)
                    {
                        body["Deflate"] = ExpressionConverter.ConvertO(__workflow_bodydeflate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Deflate"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyclean != null)
                {
                    if (__workflow_bodyclean != null)
                    {
                        body["Clean"] = ExpressionConverter.ConvertO(__workflow_bodyclean);
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
