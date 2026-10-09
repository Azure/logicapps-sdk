//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Prexviewip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PrexviewipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prexviewip")]
        [WorkflowExpressionFactory(nameof(__BuildTransform))]
        public IBodyWorkflowAction<TransformPostResponse> Transform([WorkflowExpression] Func<bodyoutputInput> bodyoutput, [WorkflowExpression] Func<string> bodytemplate, [WorkflowExpression] Func<string> bodyxml = null, [WorkflowExpression] Func<string> bodyjson = null, [WorkflowExpression] Func<string> bodytemplateBackup = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TransformPostResponse> __BuildTransform(WorkflowExpression<bodyoutputInput> bodyoutput, WorkflowExpression<string> bodytemplate, WorkflowExpression<string> bodyxml = null, WorkflowExpression<string> bodyjson = null, WorkflowExpression<string> bodytemplateBackup = null, WorkflowExpression<string> bodynote = null)
        {
            WorkflowExpression.Validate(bodyoutput, nameof(bodyoutput), required: true);
            WorkflowExpression.Validate(bodytemplate, nameof(bodytemplate), required: true);
            WorkflowExpression.Validate(bodyxml, nameof(bodyxml), required: false);
            WorkflowExpression.Validate(bodyjson, nameof(bodyjson), required: false);
            WorkflowExpression.Validate(bodytemplateBackup, nameof(bodytemplateBackup), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<TransformPostResponse>(() =>
            {
                var apiCallPath = "/transform";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyxml != null)
                {
                    body["xml"] = ExpressionConverter.ConvertO(bodyxml);
                    bodypropCount++;
                }

                if (bodyjson != null)
                {
                    body["json"] = ExpressionConverter.ConvertO(bodyjson);
                    bodypropCount++;
                }

                bodypropCount++;
                body["output"] = ExpressionConverter.ConvertO(bodyoutput);
                bodypropCount++;
                body["template"] = ExpressionConverter.ConvertO(bodytemplate);
                if (bodytemplateBackup != null)
                {
                    body["templateBackup"] = ExpressionConverter.ConvertO(bodytemplateBackup);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TransformPostResponse>(callPayload);
            });
        }
    }

    public class PrexviewipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TransformPostResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutputInput
    {
        [EnumMember(Value = "pdf")]
        Pdf,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "jpg")]
        Jpg,
        [EnumMember(Value = "png")]
        Png
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Prexviewip;

    public partial class WorkflowManagedActions
    {
        public PrexviewipActions Prexviewip(string connectionId) => new PrexviewipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PrexviewipTriggers Prexviewip(string connectionId) => new PrexviewipTriggers(connectionId);
    }
}