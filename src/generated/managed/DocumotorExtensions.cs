//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documotor
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumotorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documotor")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateDoc(Expression<Func<string>> templateId, Expression<Func<acceptInput>> accept, Expression<Func<string>> stageId = null, Expression<Func<object>> documentData = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            var __workflow_documentData = WorkflowExpression.Compile(documentData, nameof(documentData), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/template/{0}/generate", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                if (__workflow_stageId != null)
                    callPayload.Headers["stageId"] = ExpressionConverter.Convert(__workflow_stageId);
                if (__workflow_documentData != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_documentData);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class DocumotorTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum acceptInput
    {
        [EnumMember(Value = "*/*")]
        Unnamed,
        [EnumMember(Value = "application/pdf")]
        ApplicationPdf
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documotor;

    public partial class WorkflowManagedActions
    {
        public DocumotorActions Documotor(string connectionId) => new DocumotorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumotorTriggers Documotor(string connectionId) => new DocumotorTriggers(connectionId);
    }
}