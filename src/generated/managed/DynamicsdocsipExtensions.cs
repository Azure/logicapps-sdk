//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsdocsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicsdocsipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsdocsip")]
        [WorkflowExpressionFactory(nameof(__BuildCompileTemplate))]
        public IBodyWorkflowAction<CompileTemplateResponse> CompileTemplate([WorkflowExpression] Func<string> templateToken, [WorkflowExpression] Func<string> docDeliveryType = null, [WorkflowExpression] Func<int> docUrlExpiresIn = null, [WorkflowExpression] Func<string> latexCompiler = null, [WorkflowExpression] Func<int> latexRuns = null, [WorkflowExpression] Func<string> mainFileName = null, [WorkflowExpression] Func<string> docFileName = null, [WorkflowExpression] Func<string> encryptType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompileTemplateResponse> __BuildCompileTemplate(WorkflowExpression<string> templateToken, WorkflowExpression<string> docDeliveryType = null, WorkflowExpression<int> docUrlExpiresIn = null, WorkflowExpression<string> latexCompiler = null, WorkflowExpression<int> latexRuns = null, WorkflowExpression<string> mainFileName = null, WorkflowExpression<string> docFileName = null, WorkflowExpression<string> encryptType = null)
        {
            WorkflowExpression.Validate(templateToken, nameof(templateToken), required: true);
            WorkflowExpression.Validate(docDeliveryType, nameof(docDeliveryType), required: false);
            WorkflowExpression.Validate(docUrlExpiresIn, nameof(docUrlExpiresIn), required: false);
            WorkflowExpression.Validate(latexCompiler, nameof(latexCompiler), required: false);
            WorkflowExpression.Validate(latexRuns, nameof(latexRuns), required: false);
            WorkflowExpression.Validate(mainFileName, nameof(mainFileName), required: false);
            WorkflowExpression.Validate(docFileName, nameof(docFileName), required: false);
            WorkflowExpression.Validate(encryptType, nameof(encryptType), required: false);
            return new DeferredBodyAction<CompileTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/templates/{0}/compile", ExpressionConverter.ConvertWithUrlEncoding(templateToken, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["doc-delivery-type"] = Convert.ToString("url");
                if (docDeliveryType != null)
                    callPayload.Queries["doc-delivery-type"] = ExpressionConverter.Convert(docDeliveryType);
                if (docUrlExpiresIn != null)
                    callPayload.Queries["doc-url-expires-in"] = ExpressionConverter.Convert(docUrlExpiresIn);
                callPayload.Queries["latex-compiler"] = Convert.ToString("pdflatex");
                if (latexCompiler != null)
                    callPayload.Queries["latex-compiler"] = ExpressionConverter.Convert(latexCompiler);
                callPayload.Queries["latex-runs"] = Convert.ToString(1);
                if (latexRuns != null)
                    callPayload.Queries["latex-runs"] = ExpressionConverter.Convert(latexRuns);
                if (mainFileName != null)
                    callPayload.Queries["main-file-name"] = ExpressionConverter.Convert(mainFileName);
                if (docFileName != null)
                    callPayload.Queries["doc-file-name"] = ExpressionConverter.Convert(docFileName);
                callPayload.Queries["encrypt-type"] = Convert.ToString("na");
                if (encryptType != null)
                    callPayload.Queries["encrypt-type"] = ExpressionConverter.Convert(encryptType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CompileTemplateResponse>(callPayload);
            });
        }
    }

    public class DynamicsdocsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompileTemplateResponse
    {
        [JsonProperty("documentStatusUrl")]
        public string DocumentStatusUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsdocsip;

    public partial class WorkflowManagedActions
    {
        public DynamicsdocsipActions Dynamicsdocsip(string connectionId) => new DynamicsdocsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DynamicsdocsipTriggers Dynamicsdocsip(string connectionId) => new DynamicsdocsipTriggers(connectionId);
    }
}