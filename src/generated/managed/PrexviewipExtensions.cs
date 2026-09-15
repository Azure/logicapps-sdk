//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Prexviewip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PrexviewipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prexviewip")]
        public IBodyWorkflowAction<TransformPostResponse> Transform(Expression<Func<bodyoutputInput>> bodyoutput, Expression<Func<string>> bodytemplate, Expression<Func<string>> bodyxml = null, Expression<Func<string>> bodyjson = null, Expression<Func<string>> bodytemplateBackup = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = "/transform";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyxml != null)
            {
                body["xml"] = CSharpExpressionConverter.ConvertToken(bodyxml);
                bodypropCount++;
            }

            if (bodyjson != null)
            {
                body["json"] = CSharpExpressionConverter.ConvertToken(bodyjson);
                bodypropCount++;
            }

            bodypropCount++;
            body["output"] = CSharpExpressionConverter.Convert(bodyoutput);
            bodypropCount++;
            body["template"] = CSharpExpressionConverter.ConvertToken(bodytemplate);
            if (bodytemplateBackup != null)
            {
                body["templateBackup"] = CSharpExpressionConverter.ConvertToken(bodytemplateBackup);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TransformPostResponse>(callPayload);
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