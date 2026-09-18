//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Voicerss
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VoicerssActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicerss")]
        public IWorkflowAction ConvertTTS([WorkflowExpression] Func<string> hl, [WorkflowExpression] Func<string> src, [WorkflowExpression] Func<cInput> c = null, [WorkflowExpression] Func<string> f = null, [WorkflowExpression] Func<string> v = null, [WorkflowExpression] Func<int> r = null, [WorkflowExpression] Func<bool> ssml = null, [WorkflowExpression] Func<bool> b64 = null)
        {
            SourceExpression.Validate(hl, nameof(hl), required: true);
            SourceExpression.Validate(src, nameof(src), required: true);
            SourceExpression.Validate(c, nameof(c), required: false);
            SourceExpression.Validate(f, nameof(f), required: false);
            SourceExpression.Validate(v, nameof(v), required: false);
            SourceExpression.Validate(r, nameof(r), required: false);
            SourceExpression.Validate(ssml, nameof(ssml), required: false);
            SourceExpression.Validate(b64, nameof(b64), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hl"] = SourceExpressionConverter.ConvertO(hl);
                if (c != null)
                    callPayload.Queries["c"] = SourceExpressionConverter.Convert(c);
                if (f != null)
                    callPayload.Queries["f"] = SourceExpressionConverter.ConvertO(f);
                callPayload.Queries["src"] = SourceExpressionConverter.ConvertO(src);
                if (v != null)
                    callPayload.Queries["v"] = SourceExpressionConverter.ConvertO(v);
                if (r != null)
                    callPayload.Queries["r"] = SourceExpressionConverter.ConvertO(r);
                if (ssml != null)
                    callPayload.Queries["ssml"] = SourceExpressionConverter.ConvertO(ssml);
                if (b64 != null)
                    callPayload.Queries["b64"] = SourceExpressionConverter.ConvertO(b64);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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