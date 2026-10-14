//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Voicerss
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class VoicerssActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicerss")]
        public IWorkflowAction ConvertTTS(Expression<Func<string>> hl, Expression<Func<string>> src, Expression<Func<cInput>> c = null, Expression<Func<string>> f = null, Expression<Func<string>> v = null, Expression<Func<int>> r = null, Expression<Func<bool>> ssml = null, Expression<Func<bool>> b64 = null)
        {
            var __workflow_hl = hl == null ? null : WorkflowExpression.Compile(hl);
            WorkflowExpression.Validate(__workflow_hl, nameof(hl), required: true);
            var __workflow_src = src == null ? null : WorkflowExpression.Compile(src);
            WorkflowExpression.Validate(__workflow_src, nameof(src), required: true);
            var __workflow_c = c == null ? null : WorkflowExpression.Compile(c);
            WorkflowExpression.Validate(__workflow_c, nameof(c), required: false);
            var __workflow_f = f == null ? null : WorkflowExpression.Compile(f);
            WorkflowExpression.Validate(__workflow_f, nameof(f), required: false);
            var __workflow_v = v == null ? null : WorkflowExpression.Compile(v);
            WorkflowExpression.Validate(__workflow_v, nameof(v), required: false);
            var __workflow_r = r == null ? null : WorkflowExpression.Compile(r);
            WorkflowExpression.Validate(__workflow_r, nameof(r), required: false);
            var __workflow_ssml = ssml == null ? null : WorkflowExpression.Compile(ssml);
            WorkflowExpression.Validate(__workflow_ssml, nameof(ssml), required: false);
            var __workflow_b64 = b64 == null ? null : WorkflowExpression.Compile(b64);
            WorkflowExpression.Validate(__workflow_b64, nameof(b64), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hl"] = ExpressionConverter.Convert(__workflow_hl);
                if (__workflow_c != null)
                    callPayload.Queries["c"] = ExpressionConverter.Convert(__workflow_c);
                if (__workflow_f != null)
                    callPayload.Queries["f"] = ExpressionConverter.Convert(__workflow_f);
                callPayload.Queries["src"] = ExpressionConverter.Convert(__workflow_src);
                if (__workflow_v != null)
                    callPayload.Queries["v"] = ExpressionConverter.Convert(__workflow_v);
                if (__workflow_r != null)
                    callPayload.Queries["r"] = ExpressionConverter.Convert(__workflow_r);
                if (__workflow_ssml != null)
                    callPayload.Queries["ssml"] = ExpressionConverter.Convert(__workflow_ssml);
                if (__workflow_b64 != null)
                    callPayload.Queries["b64"] = ExpressionConverter.Convert(__workflow_b64);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class VoicerssTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum cInput
    {
        MP3,
        WAV,
        AAC,
        OGG,
        CAF
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Voicerss;

    public partial class WorkflowManagedActions
    {
        public VoicerssActions Voicerss(string connectionId) => new VoicerssActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VoicerssTriggers Voicerss(string connectionId) => new VoicerssTriggers(connectionId);
    }
}
