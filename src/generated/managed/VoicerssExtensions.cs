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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildConvertTTS(WorkflowValue<string> hl, WorkflowValue<string> src, WorkflowValue<cInput> c = null, WorkflowValue<string> f = null, WorkflowValue<string> v = null, WorkflowValue<int> r = null, WorkflowValue<bool> ssml = null, WorkflowValue<bool> b64 = null)
        {
            WorkflowValue.Validate(hl, nameof(hl), required: true);
            WorkflowValue.Validate(src, nameof(src), required: true);
            WorkflowValue.Validate(c, nameof(c), required: false);
            WorkflowValue.Validate(f, nameof(f), required: false);
            WorkflowValue.Validate(v, nameof(v), required: false);
            WorkflowValue.Validate(r, nameof(r), required: false);
            WorkflowValue.Validate(ssml, nameof(ssml), required: false);
            WorkflowValue.Validate(b64, nameof(b64), required: false);
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
