//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documotor
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumotorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documotor")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateDoc))]
        public IBodyWorkflowAction<string> GenerateDoc([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<acceptInput> accept, [WorkflowExpression] Func<string> stageId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGenerateDoc(WorkflowValue<string> templateId, WorkflowValue<acceptInput> accept, WorkflowValue<string> stageId = null)
        {
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(accept, nameof(accept), required: true);
            WorkflowValue.Validate(stageId, nameof(stageId), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/template/{0}/generate", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                if (stageId != null)
                    callPayload.Headers["stageId"] = ExpressionConverter.Convert(stageId);
                var documentData = new JObject();
                var documentDatapropCount = 0;
                if (documentDatapropCount > 0)
                {
                    callPayload.Body = documentData;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class DocumotorTriggers([ConnectionName] string connectionId)
    {
    }

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
