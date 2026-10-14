//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Prexviewip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PrexviewipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prexviewip")]
        public IBodyWorkflowAction<TransformPostResponse> Transform(Expression<Func<bodyoutputInput>> bodyoutput, Expression<Func<string>> bodytemplate, Expression<Func<string>> bodyxml = null, Expression<Func<string>> bodyjson = null, Expression<Func<string>> bodytemplateBackup = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_bodyoutput = bodyoutput == null ? null : WorkflowExpression.Compile(bodyoutput);
            WorkflowExpression.Validate(__workflow_bodyoutput, nameof(bodyoutput), required: true);
            var __workflow_bodytemplate = bodytemplate == null ? null : WorkflowExpression.Compile(bodytemplate);
            WorkflowExpression.Validate(__workflow_bodytemplate, nameof(bodytemplate), required: true);
            var __workflow_bodyxml = bodyxml == null ? null : WorkflowExpression.Compile(bodyxml);
            WorkflowExpression.Validate(__workflow_bodyxml, nameof(bodyxml), required: false);
            var __workflow_bodyjson = bodyjson == null ? null : WorkflowExpression.Compile(bodyjson);
            WorkflowExpression.Validate(__workflow_bodyjson, nameof(bodyjson), required: false);
            var __workflow_bodytemplateBackup = bodytemplateBackup == null ? null : WorkflowExpression.Compile(bodytemplateBackup);
            WorkflowExpression.Validate(__workflow_bodytemplateBackup, nameof(bodytemplateBackup), required: false);
            var __workflow_bodynote = bodynote == null ? null : WorkflowExpression.Compile(bodynote);
            WorkflowExpression.Validate(__workflow_bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<TransformPostResponse>(() =>
            {
                var apiCallPath = "/transform";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyxml != null)
                {
                    body["xml"] = ExpressionConverter.ConvertO(__workflow_bodyxml);
                    bodypropCount++;
                }

                if (__workflow_bodyjson != null)
                {
                    body["json"] = ExpressionConverter.ConvertO(__workflow_bodyjson);
                    bodypropCount++;
                }

                bodypropCount++;
                body["output"] = ExpressionConverter.ConvertO(__workflow_bodyoutput);
                bodypropCount++;
                body["template"] = ExpressionConverter.ConvertO(__workflow_bodytemplate);
                if (__workflow_bodytemplateBackup != null)
                {
                    body["templateBackup"] = ExpressionConverter.ConvertO(__workflow_bodytemplateBackup);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
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
