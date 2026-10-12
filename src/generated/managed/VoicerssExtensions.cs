//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Voicerss
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VoicerssActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicerss")]
        [WorkflowExpressionFactory(nameof(__BuildConvertTTS))]
        public IWorkflowAction ConvertTTS([WorkflowExpression] Func<string> hl, [WorkflowExpression] Func<string> src, [WorkflowExpression] Func<cInput> c = null, [WorkflowExpression] Func<string> f = null, [WorkflowExpression] Func<string> v = null, [WorkflowExpression] Func<int> r = null, [WorkflowExpression] Func<bool> ssml = null, [WorkflowExpression] Func<bool> b64 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildConvertTTS(WorkflowExpression<string> hl, WorkflowExpression<string> src, WorkflowExpression<cInput> c = null, WorkflowExpression<string> f = null, WorkflowExpression<string> v = null, WorkflowExpression<int> r = null, WorkflowExpression<bool> ssml = null, WorkflowExpression<bool> b64 = null)
        {
            WorkflowExpression.Validate(hl, nameof(hl), required: true);
            WorkflowExpression.Validate(src, nameof(src), required: true);
            WorkflowExpression.Validate(c, nameof(c), required: false);
            WorkflowExpression.Validate(f, nameof(f), required: false);
            WorkflowExpression.Validate(v, nameof(v), required: false);
            WorkflowExpression.Validate(r, nameof(r), required: false);
            WorkflowExpression.Validate(ssml, nameof(ssml), required: false);
            WorkflowExpression.Validate(b64, nameof(b64), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hl"] = ExpressionConverter.Convert(hl);
                if (c != null)
                    callPayload.Queries["c"] = ExpressionConverter.Convert(c);
                if (f != null)
                    callPayload.Queries["f"] = ExpressionConverter.Convert(f);
                callPayload.Queries["src"] = ExpressionConverter.Convert(src);
                if (v != null)
                    callPayload.Queries["v"] = ExpressionConverter.Convert(v);
                if (r != null)
                    callPayload.Queries["r"] = ExpressionConverter.Convert(r);
                if (ssml != null)
                    callPayload.Queries["ssml"] = ExpressionConverter.Convert(ssml);
                if (b64 != null)
                    callPayload.Queries["b64"] = ExpressionConverter.Convert(b64);
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